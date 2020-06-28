using DevOne.Security.Cryptography.BCrypt;
using Microsoft.AspNet.SignalR.Client;
using Newtonsoft.Json;
using NLog;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingnalRClient
{
    /// <summary>
    /// SignalR实时通信 客户端
    /// </summary>
    public partial class FomClient : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public IHubProxy HubProxy { get; set; }
        public HubConnection Connection { get; set; }

        public FomClient()
        {
            InitializeComponent();
        }

        private void BtnSendmessage_Click(object sender, EventArgs e)
        {
            if (tbxMessage.Text.Length == 0)
                return;

            var message = new TextMessage()
            {
                MsgType = "text",
                FromConnId = "ConnId",
                ToConnId = "toId",
                Message = richTextBox.Text,
                Success = true
            };

            HubProxy.Invoke("AddMessage", JsonConvert.SerializeObject(message));
            richTextBox.Text = string.Empty;
            richTextBox.Focus();
        }

        private void FomClient_Load(object sender, EventArgs e)
        {
            InitHub();
            StartConnect();
        }

        private void FomClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Connection != null)
            {
                Connection.Stop();
                Connection.Dispose();
            }
        }

        /// <summary>
        /// 初始化服务连接
        /// </summary>
        private void InitHub()
        {
            //连接的时候传递参数Param
            //var param = new Dictionary<string, string> {
            //    { "Param", JsonConvert.SerializeObject(client) }
            //};
            //var serverUrl = "http://localhost:16888/";
            var serverUrl = System.Configuration.ConfigurationManager.AppSettings["url"];
            //创建连接对象，并实现相关事件
            //Connection = new HubConnection(serverUrl, param);
            Connection = new HubConnection(serverUrl);
            Connection.Closed += HubConnection_Closed;
            Connection.Received += HubConnection_Received;
            Connection.Reconnected += HubConnection_Succeed;
            Connection.TransportConnectTimeout = new TimeSpan(3000);

            //绑定一个集线器
            HubProxy = Connection.CreateHubProxy("SignalRHub");
            AddProtocal();
        }

        private void HubConnection_Succeed()
        {
            Console.WriteLine("客户端连接成功。。。。");
            ShowMessage("客户端连接成功。。。。");
        }

        private void HubConnection_Received(string obj)
        {
            logger.Info($"客户端接收数据。。。。{obj}");
            ShowMessage($"客户端接收数据。。。。{obj}");
        }

        private void HubConnection_Closed()
        {
            logger.Info("客户端关闭连接。。。。");
        }

        private async Task StartConnect()
        {
            try
            {
                //开始连接
                await Connection.Start();
                //await hubProxy.Invoke<CommonResult>("CheckLogin", this.txtUser.Text);
                logger.Info("开始连接。。。。");
                ShowMessage("开始连接。。。。服务器");
                HubConnection_Succeed();//处理连接后的初始化
            }
            catch (Exception ex)
            {
                logger.Error(ex.StackTrace);
                ShowMessage("服务器连接失败：" + ex.Message);
                InitControlStatus(false);
                return;
            }
        }

        private void ShowMessage(string message)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                richTextBox.AppendText(message + Environment.NewLine);
                richTextBox.ScrollToCaret();
            });
        }

        /// <summary>
        /// 对各种协议的事件进行处理
        /// </summary>
        private void AddProtocal()
        {
            //接收实时信息
            HubProxy.On<string>("AddMessage", DealMessage);

            //连接上触发connected处理
            HubProxy.On("logined", () =>
                Invoke((Action)(() =>
                {
                    Text = string.Format("当前用户:{0}", 11111);
                    richTextBox.AppendText(string.Format("以名称【" + 1111 + "】连接成功!" + Environment.NewLine));
                    InitControlStatus(true);
                }))
            );

            //服务端拒绝的处理
            HubProxy.On("rejected", () =>
                Invoke((Action)(() =>
                {
                    richTextBox.AppendText(string.Format("无法使用名称【" + 1111 + "】进行连接!" + Environment.NewLine));
                    InitControlStatus(false);
                    CloseHub();
                }))
            );

            //客户端收到服务关闭消息
            HubProxy.On("SendClose", () =>
            {
                CloseHub();
            });
        }

        /// <summary>
        /// 处理文本消息
        /// </summary>
        /// <param name="data"></param>
        /// <param name="basemsg"></param>
        //private void DealText(string data, BaseMessage basemsg)
        //{
        ////JSON转换为文本消息
        //var msg = JsonConvert.DeserializeObject<TextMessage>(data);
        //var ownerClient = ClientList.FirstOrDefault(f => f.ConnId == basemsg.FromConnId);
        //var ownerName = ownerClient == null ? "系统广播" : ownerClient.Name;

        //this.Invoke(new Action(() =>
        //{
        //    richTextBox.AppendText(string.Format("{0} - {1}:\n {2}" + Environment.NewLine, DateTime.Now, ownerName, msg.Message));
        //    richTextBox.ScrollToCaret();
        //}));
        //}

        private void InitControlStatus(bool enable)
        {
            btnSendmessage.Enabled = !enable;
            btnStopService.Enabled = enable;
            btnBroadcastMessage.Enabled = enable;
            btnConnectClientInfo.Enabled = enable;
        }

        private void DealMessage(string onData)
        {
            logger.Info("客户端收到服务端数据：" + onData);
            ShowMessage("客户端收到服务端数据：" + onData);
        }

        private void CloseHub()
        {
            ShowMessage("CloseHub.....");
            if (Connection != null)
            {
                Connection.Dispose();
                Connection = null;
            }

            if (HubProxy != null)
            {
                HubProxy = null;
            }
        }
    }

    /// <summary>
    /// 传递文本信息类
    /// </summary>
    internal class TextMessage
    {
        public object MsgType { get; set; }
        public object FromConnId { get; set; }
        public object ToConnId { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
