namespace SingnalRServer
{
    partial class FomServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnectClientInfo = new System.Windows.Forms.Button();
            this.btnBroadcastMessage = new System.Windows.Forms.Button();
            this.btnStopService = new System.Windows.Forms.Button();
            this.btnStartService = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbShowInfo = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConnectClientInfo);
            this.panel1.Controls.Add(this.btnBroadcastMessage);
            this.panel1.Controls.Add(this.btnStopService);
            this.panel1.Controls.Add(this.btnStartService);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 52);
            this.panel1.TabIndex = 0;
            // 
            // btnConnectClientInfo
            // 
            this.btnConnectClientInfo.Location = new System.Drawing.Point(423, 7);
            this.btnConnectClientInfo.Name = "btnConnectClientInfo";
            this.btnConnectClientInfo.Size = new System.Drawing.Size(117, 39);
            this.btnConnectClientInfo.TabIndex = 3;
            this.btnConnectClientInfo.Text = "连接客户端信息";
            this.btnConnectClientInfo.UseVisualStyleBackColor = true;
            this.btnConnectClientInfo.Click += new System.EventHandler(this.BtnConnectClientInfo_Click);
            // 
            // btnBroadcastMessage
            // 
            this.btnBroadcastMessage.Location = new System.Drawing.Point(292, 7);
            this.btnBroadcastMessage.Name = "btnBroadcastMessage";
            this.btnBroadcastMessage.Size = new System.Drawing.Size(117, 39);
            this.btnBroadcastMessage.TabIndex = 2;
            this.btnBroadcastMessage.Text = "广播消息";
            this.btnBroadcastMessage.UseVisualStyleBackColor = true;
            this.btnBroadcastMessage.Click += new System.EventHandler(this.BtnBroadcastMessage_Click);
            // 
            // btnStopService
            // 
            this.btnStopService.Location = new System.Drawing.Point(161, 7);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(117, 39);
            this.btnStopService.TabIndex = 1;
            this.btnStopService.Text = "停止服务";
            this.btnStopService.UseVisualStyleBackColor = true;
            this.btnStopService.Click += new System.EventHandler(this.BtnStopService_Click);
            // 
            // btnStartService
            // 
            this.btnStartService.Location = new System.Drawing.Point(30, 7);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(117, 39);
            this.btnStartService.TabIndex = 0;
            this.btnStartService.Text = "启动服务";
            this.btnStartService.UseVisualStyleBackColor = true;
            this.btnStartService.Click += new System.EventHandler(this.BtnStartService_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbShowInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 386);
            this.panel2.TabIndex = 1;
            // 
            // rtbShowInfo
            // 
            this.rtbShowInfo.BackColor = System.Drawing.SystemColors.Window;
            this.rtbShowInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbShowInfo.Location = new System.Drawing.Point(0, 0);
            this.rtbShowInfo.Name = "rtbShowInfo";
            this.rtbShowInfo.Size = new System.Drawing.Size(794, 386);
            this.rtbShowInfo.TabIndex = 0;
            this.rtbShowInfo.Text = "";
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 392F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // FomServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FomServer";
            this.Text = "FomServer 服务端";
            this.Load += new System.EventHandler(this.FomServer_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConnectClientInfo;
        private System.Windows.Forms.Button btnBroadcastMessage;
        private System.Windows.Forms.Button btnStopService;
        private System.Windows.Forms.Button btnStartService;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox rtbShowInfo;
    }
}