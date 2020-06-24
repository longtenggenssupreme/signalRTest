using log4net;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;
using SingnalRServer;
using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingnalRServer
{
    /// <summary>
    /// SignalR实时通信 服务端
    /// </summary>
    public partial class FomServer : Form
    {
        readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// 启动SignalR实时通信的通讯映射关系对象
        /// </summary>
        public IDisposable SignalR { get; set; }

        /// <summary>
        /// SignalR实时通信的核心对象
        /// </summary>
        public IHubContext HubContext { get; set; }

        public FomServer()
        {
            InitializeComponent();
        }

        private void FomServer_Load(object sender, EventArgs e)
        {
            BtnStartService_Click(null,null);
        }

        /// <summary>
        /// 启动服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStartService_Click(object sender, EventArgs e)
        {
            btnStartService.Enabled = false;
            Log.Info("SignalR实时通信--》服务器启动中....");
            ShowMessage("SignalR实时通信--》服务器启动中....");
            ServerStart();
        }

        private async void BtnStopService_Click(object sender, EventArgs e)
        {
            btnStopService.Enabled = false;
            Log.Info("停止服务....");
            await StopServer();
        }

        /// <summary>
        /// 开启服务
        /// </summary>
        private void ServerStart()
        {
            var serverUrl = System.Configuration.ConfigurationManager.AppSettings["url"] ?? "http://localhost:16888";
            try
            {
                //开启服务
                SignalR = WebApp.Start<Startup>(serverUrl);
                HubContext = GlobalHost.ConnectionManager.GetHubContext<SignalRHub>();
                InitControlState(true);
            }
            catch (Exception ex)
            {
                Log.Error("服务开启失败,原因:" + ex.Message);
                ShowMessage("服务开启失败,原因:" + ex.Message);
                InitControlState(false);
                return;
            }
            ShowMessage("服务开启成功 : " + serverUrl);
            Log.Info("服务开启成功 : " + serverUrl);
        }

        private void ShowMessage(string message)
        {
            if (IsHandleCreated)
            {
                if (InvokeRequired)
                {
                    BeginInvoke((MethodInvoker)delegate ()
                    {
                        rtbShowInfo.AppendText(message + Environment.NewLine);
                    });
                }
                else
                {
                    rtbShowInfo.AppendText(message + Environment.NewLine);
                }
            }
        }

        /// <summary>
        /// 停止服务
        /// </summary>
        /// <returns></returns>
        private async Task StopServer()
        {
            if (SignalR != null)
            {
                //向客户端广播消息
                //hubContext = GlobalHost.ConnectionManager.GetHubContext<SignalRHub>();
                await HubContext.Clients.All.SendClose("服务端已关闭");                
                //await hubContext.Clients.User("").SendClose("服务端已关闭");
                //释放对象
                SignalR.Dispose();
                SignalR = null;
                Log.Info("服务端已关闭...");
            }
        }

        private void InitControlState(bool enable)
        {
            if (IsHandleCreated && InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate ()
                {
                    btnStartService.Enabled = !enable;
                    btnStopService.Enabled = enable;
                    btnBroadcastMessage.Enabled = enable;
                    btnConnectClientInfo.Enabled = enable;
                });
            }

        }

        private void BtnBroadcastMessage_Click(object sender, EventArgs e)
        {
            Log.Info("广播消息...");
            HubContext.Clients.All.AddMessage("123456789");
        }

        private void BtnConnectClientInfo_Click(object sender, EventArgs e)
        {
            Log.Info("连接客户端信息...");
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="data"></param>
        public void AddMessage(string data)
        {
            Console.WriteLine($"接收数据：{data}");
        }

    }
}
