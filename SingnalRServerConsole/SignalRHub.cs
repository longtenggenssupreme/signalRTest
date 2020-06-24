using Microsoft.AspNet.SignalR;
using System;
using System.Threading.Tasks;

namespace SingnalRServer
{
    public class SignalRHub : Hub
    {
        public delegate void DelegateCallBack(string a);
        public DelegateCallBack CallBack { get; set; }

        /// <summary>
        /// 连接成功
        /// </summary>
        /// <returns></returns>
        public override Task OnConnected()
        {
            //var client = JsonConvert.DeserializeObject<ClientModel>(Context.QueryString.Get("Param"));
            var client = "Param";
            if (client != null)
            {
                #region MyRegion
                //client.ConnId = Context.ConnectionId;
                ////将客户端连接加入列表
                //if (!Portal.gc.ClientList.Exists(e => e.ConnId == client.ConnId))
                //{
                //    Portal.gc.ClientList.Add(client);
                //}
                //Groups.Add(client.ConnId, "Client");
                Groups.Add("12222", "Client");

                ////向服务端写入一些数据
                //Portal.gc.MainForm.WriteToInfo("客户端连接ID:" + Context.ConnectionId);
                //Portal.gc.MainForm.WriteToInfo(string.Format("客户端 【{0}】接入: {1} ,  IP地址: {2} \n 客户端总数: {3}", client.Name, Context.ConnectionId, client.IPAddress, Portal.gc.ClientList.Count));

                ////先所有连接客户端广播连接客户状态
                //var imcp = new StateMessage()
                //{
                //    Client = client,
                //    MsgType = MsgType.State,
                //    FromConnId = client.ConnId,
                //    Success = true
                //};
                //var jsonStr = JsonConvert.SerializeObject(imcp); 
                #endregion
                var jsonStr = "123";
                Clients.Group("Client", new string[0]).AddMessage(jsonStr);

                return base.OnConnected();

            }
            return Task.FromResult(0);
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        /// <param name="stopCalled"></param>
        /// <returns></returns>
        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }

        /// <summary>
        /// 重连
        /// </summary>
        /// <returns></returns>
        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="data"></param>
        public void AddMessage(string data) {
            Console.WriteLine($"接收数据：{data}");
            CallBack?.Invoke(data);
        }

        /// <summary>
        /// 获取在线的客户端
        /// </summary>
        public void GetOnlineClients()
        {

        }        
    }
}
