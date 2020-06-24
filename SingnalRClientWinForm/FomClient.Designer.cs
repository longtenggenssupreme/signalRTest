namespace SingnalRClient
{
    partial class FomClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.btnConnectClientInfo = new System.Windows.Forms.Button();
            this.btnBroadcastMessage = new System.Windows.Forms.Button();
            this.btnStopService = new System.Windows.Forms.Button();
            this.btnSendmessage = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 365F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxMessage);
            this.panel1.Controls.Add(this.btnConnectClientInfo);
            this.panel1.Controls.Add(this.btnBroadcastMessage);
            this.panel1.Controls.Add(this.btnSendmessage);
            this.panel1.Controls.Add(this.btnStopService);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 79);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(794, 359);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "123";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 359);
            this.panel2.TabIndex = 1;
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(24, 24);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(177, 39);
            this.tbxMessage.TabIndex = 8;
            // 
            // btnConnectClientInfo
            // 
            this.btnConnectClientInfo.Location = new System.Drawing.Point(636, 24);
            this.btnConnectClientInfo.Name = "btnConnectClientInfo";
            this.btnConnectClientInfo.Size = new System.Drawing.Size(117, 39);
            this.btnConnectClientInfo.TabIndex = 7;
            this.btnConnectClientInfo.Text = "连接客户端信息";
            this.btnConnectClientInfo.UseVisualStyleBackColor = true;
            // 
            // btnBroadcastMessage
            // 
            this.btnBroadcastMessage.Location = new System.Drawing.Point(505, 24);
            this.btnBroadcastMessage.Name = "btnBroadcastMessage";
            this.btnBroadcastMessage.Size = new System.Drawing.Size(117, 39);
            this.btnBroadcastMessage.TabIndex = 6;
            this.btnBroadcastMessage.Text = "广播消息";
            this.btnBroadcastMessage.UseVisualStyleBackColor = true;
            // 
            // btnStopService
            // 
            this.btnStopService.Location = new System.Drawing.Point(374, 24);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(117, 39);
            this.btnStopService.TabIndex = 5;
            this.btnStopService.Text = "停止服务";
            this.btnStopService.UseVisualStyleBackColor = true;
            // 
            // btnSendmessage
            // 
            this.btnSendmessage.Location = new System.Drawing.Point(243, 24);
            this.btnSendmessage.Name = "btnSendmessage";
            this.btnSendmessage.Size = new System.Drawing.Size(117, 39);
            this.btnSendmessage.TabIndex = 4;
            this.btnSendmessage.Text = "发送消息";
            this.btnSendmessage.UseVisualStyleBackColor = true;
            this.btnSendmessage.Click += new System.EventHandler(this.BtnSendmessage_Click);
            // 
            // FomClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FomClient";
            this.Text = "signalRClient 客户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FomClient_FormClosing);
            this.Load += new System.EventHandler(this.FomClient_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConnectClientInfo;
        private System.Windows.Forms.Button btnBroadcastMessage;
        private System.Windows.Forms.Button btnStopService;
        private System.Windows.Forms.Button btnSendmessage;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox tbxMessage;
    }
}

