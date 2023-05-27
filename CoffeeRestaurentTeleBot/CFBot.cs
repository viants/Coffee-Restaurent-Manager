using CoffeeRestaurentTeleBot.Services;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace CoffeeRestaurentTeleBot
{
    public partial class CFBot : Form
    {

        TelegramBotClient botClient;
        int logCounter = 0;

        void AddLog(string msg)
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.BeginInvoke((MethodInvoker)delegate ()
                {
                    AddLog(msg);
                });
            }
            else
            {
                logCounter++;
                if (logCounter > 100)
                {
                    txtLog.Clear();
                    logCounter = 0;
                }
                txtLog.AppendText(msg + "\r\n");
            }
        }
        public CFBot()
        {
            InitializeComponent();
            string token = "6015445751:AAGWDtvaLwQTema6qj3Ib6MHUrV58Pz9Pv4";

            botClient = new TelegramBotClient(token);

            using CancellationTokenSource cts = new();

            // StartReceiving does not block the caller thread. Receiving is done on the ThreadPool.
            ReceiverOptions receiverOptions = new()
            {
                AllowedUpdates = Array.Empty<UpdateType>() // receive all update types except ChatMember related updates
            };

            botClient.StartReceiving(
                updateHandler: HandleUpdateAsync,  //hàm xử lý khi có người chát đến
                pollingErrorHandler: HandlePollingErrorAsync,
                receiverOptions: receiverOptions,
                cancellationToken: cts.Token
            );
            Task<User> me = botClient.GetMeAsync();

            AddLog($"Bot begin working: @{me.Result.Username}");


            async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
            {
                // Only process Message updates: https://core.telegram.org/bots/api#message
                bool ok = false;
                Telegram.Bot.Types.Message? message = null;
                if (update.Message != null)
                {
                    message = update.Message;
                    ok = true;
                }

                if (update.EditedMessage != null)
                {
                    message = update.EditedMessage;
                    ok = true;
                }

                if (!ok || message == null) return;

                string? messageText = message.Text;
                if (messageText == null) return;
                var username = message.Chat.Username;
                var chatId = message.Chat.Id;
                int userSelected;
                using (SqlService sqlService = new SqlService())
                {
                    userSelected = sqlService.ExcuseScalarQuery($"SELECT UserSelect FROM Customers WHERE Id = N'{chatId}'");
                }
                AddLog($"{username}: {userSelected}");

                string reply = "";
                if (userSelected == 0)
                {
                    if (messageText.StartsWith("/start"))
                    {
                        using (SqlService service = new SqlService())
                        {
                            string sql = $"EXEC sp_tete_customer @id = N'{chatId.ToString()}', @name = N'{username}'";
                            service.PutDataQuery(sql);
                        }
                        reply = "Hướng dẫn sử dụng bot 🤖 của Coffee Restaurent 😊:\n/order: để được gọi và đặt đồ ăn 🍵🍹\n/menu: để lấy menu của quán nhé 📄\n- Cần hỗ trợ hãy gọi: 0852072574 ☎️";
                        Telegram.Bot.Types.Message sentMessage = await botClient.SendTextMessageAsync(
                       chatId: chatId,
                       text: reply
                      );
                    }
                    else if (messageText.StartsWith("/help"))
                    {
                        //SqlService sqlService = new SqlService();
                        reply = "Hướng dẫn sử dụng bot 🤖 của Coffee Restaurent 😊:\n/order: để được gọi và đặt đồ ăn 🍵🍹\n/menu: để lấy menu của quán nhé 📄\n- Cần hỗ trợ hãy gọi: 0852072574 ☎️";
                        Telegram.Bot.Types.Message sentMessage = await botClient.SendTextMessageAsync(
                       chatId: chatId,
                       text: reply
                      );
                    }
                    else if (messageText.StartsWith("/dl "))
                    {
                        string path = messageText.Substring(4);

                        string fn = System.IO.Path.GetFileName(path);
                        reply = $"Đã gửi file {fn} qua telegram rồi, click vào mũi tên để lưu về máy";

                        await using Stream stream = System.IO.File.OpenRead(path);
                        Telegram.Bot.Types.Message fileMessage = await botClient.SendDocumentAsync(
                            chatId: chatId,
                            document: InputFile.FromStream(stream: stream, fileName: fn),
                            caption: $"Download file {path}");
                    }
                    else if (messageText.StartsWith("/menu"))
                    {

                        using (SqlService service = new SqlService())
                        {
                            string query = "SELECT Id, Name, Price FROM Products";
                            DataTable dt = service.GetDataQuery(query);
                            reply = $"Chúng tớ có tất cả {dt.Rows.Count} sản phẩm đang bán 🍹\n";
                            Telegram.Bot.Types.Message sentSubMessage = await botClient.SendTextMessageAsync(
                               chatId: chatId,
                               text: reply);

                            foreach (DataRow row in dt.Rows)
                            {
                                reply = "";
                                reply += "Mã: " + row["Id"].ToString() + "\n";
                                reply += "Tên sản phẩm: " + row["Name"].ToString() + "\n";
                                reply += "Giá: " + row["Price"].ToString() + "đ\n";

                                Telegram.Bot.Types.Message sentSubMessage1 = await botClient.SendTextMessageAsync(
                                    chatId: chatId,
                                    text: reply);
                            }
                        }

                        reply = $"{message.Chat.LastName} muốn đặt sản phẩm gì ạ? 😊\n Hãy nhập Mã sản phẩm + số lượng, ví dụ: ICETEA01 3";
                        Telegram.Bot.Types.Message sentMessage = await botClient.SendTextMessageAsync(
                       chatId: chatId,
                       text: reply
                      );
                        using (SqlService sqlService = new SqlService())
                        {
                            sqlService.PutDataQuery($"UPDATE Customers SET UserSelect = 1 WHERE Id = N'{chatId}'");
                        }
                    }
                    else
                    {
                        reply = "Xin lỗi, tớ không hiểu yêu cầu của cậu, hãy sử dụng /help để được trợ giúp nhé 😊";
                        Telegram.Bot.Types.Message sentMessage = await botClient.SendTextMessageAsync(
                       chatId: chatId,
                       text: reply
                      );
                    }
                }
                else if (userSelected == 1)
                {
                    string[] cmd = messageText.Split(' ');
                    int res = 0;
                    using(SqlService sql = new SqlService())
                    {
                        res = sql.ExcuseScalarQuery($"SELECT COUNT(*) FROM Products WHERE Id = N'{cmd[0]}'");
                    }
                    if(res > 0)
                    {
                        reply = $"Đã chọn sản phẩm {cmd[0]} với số lượng là {cmd[1]}";
                        using (SqlService sql = new SqlService())
                        {
                            sql.ExcureNonQuery($"UPDATE Customers SET UserSelect = 0 WHERE Id = '{chatId}'");
                        }
                        Telegram.Bot.Types.Message sentSubMessage2 = await botClient.SendTextMessageAsync(
                                    chatId: chatId,
                                    text: reply);
                    }
                    else
                    {
                        reply = "Không có mã sản phẩm này, xin hãy nhập lại. Hoặc nhập /exit để thoát";
                        Telegram.Bot.Types.Message sentSubMessage2 = await botClient.SendTextMessageAsync(
                                    chatId: chatId,
                                    text: reply);
                        if(messageText.StartsWith("/exit"))
                        {
                            using (SqlService sql = new SqlService())
                            {
                                sql.ExcureNonQuery($"UPDATE Customers SET UserSelect = 0 WHERE Id = '{chatId}'");
                            }
                        }
                    }
                    


                }

                // Echo received message text
                
            }

            Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
            {
                var ErrorMessage = exception switch
                {
                    ApiRequestException apiRequestException
                        => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                    _ => exception.ToString()
                };

                AddLog(ErrorMessage);
                return Task.CompletedTask;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}