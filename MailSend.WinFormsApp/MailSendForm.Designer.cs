
namespace MailSend.WinFormsApp
{
    partial class MailSendForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Lb_SenderRow_Title = new System.Windows.Forms.Label();
            this.Lb_ClientRow_Title = new System.Windows.Forms.Label();
            this.Lb_ClientRow_Port = new System.Windows.Forms.Label();
            this.Lb_DestinationRow_Title = new System.Windows.Forms.Label();
            this.Txb_DestinationRow_Value = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TbCtrl_Main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Txb_MailBody = new System.Windows.Forms.TextBox();
            this.Lbl_MailSubject = new System.Windows.Forms.Label();
            this.Txb_MailSubject = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Btn_ChangePort = new System.Windows.Forms.Button();
            this.Btn_ChangeSender = new System.Windows.Forms.Button();
            this.Btn_ChangeHost = new System.Windows.Forms.Button();
            this.Txb_SenderRow_Value = new System.Windows.Forms.TextBox();
            this.Txb_ClientRow_HostValue = new System.Windows.Forms.TextBox();
            this.Txb_ClientRow_PortValue = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.TbCtrl_Main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Lb_SenderRow_Title, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lb_ClientRow_Title, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Lb_ClientRow_Port, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Lb_DestinationRow_Title, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Txb_DestinationRow_Value, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Btn_ChangePort, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Btn_ChangeSender, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_ChangeHost, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Txb_SenderRow_Value, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Txb_ClientRow_HostValue, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Txb_ClientRow_PortValue, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.73684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(949, 610);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Lb_SenderRow_Title
            // 
            this.Lb_SenderRow_Title.AutoSize = true;
            this.Lb_SenderRow_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_SenderRow_Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_SenderRow_Title.Location = new System.Drawing.Point(57, 28);
            this.Lb_SenderRow_Title.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.Lb_SenderRow_Title.Name = "Lb_SenderRow_Title";
            this.Lb_SenderRow_Title.Size = new System.Drawing.Size(144, 25);
            this.Lb_SenderRow_Title.TabIndex = 0;
            this.Lb_SenderRow_Title.Text = "Отправитель:";
            this.Lb_SenderRow_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_ClientRow_Title
            // 
            this.Lb_ClientRow_Title.AutoSize = true;
            this.Lb_ClientRow_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_ClientRow_Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_ClientRow_Title.Location = new System.Drawing.Point(57, 59);
            this.Lb_ClientRow_Title.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.Lb_ClientRow_Title.Name = "Lb_ClientRow_Title";
            this.Lb_ClientRow_Title.Size = new System.Drawing.Size(144, 25);
            this.Lb_ClientRow_Title.TabIndex = 3;
            this.Lb_ClientRow_Title.Text = "Используется сервер:";
            this.Lb_ClientRow_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_ClientRow_Port
            // 
            this.Lb_ClientRow_Port.AutoSize = true;
            this.Lb_ClientRow_Port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_ClientRow_Port.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_ClientRow_Port.Location = new System.Drawing.Point(57, 90);
            this.Lb_ClientRow_Port.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.Lb_ClientRow_Port.Name = "Lb_ClientRow_Port";
            this.Lb_ClientRow_Port.Size = new System.Drawing.Size(144, 25);
            this.Lb_ClientRow_Port.TabIndex = 6;
            this.Lb_ClientRow_Port.Text = "Порт:";
            this.Lb_ClientRow_Port.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_DestinationRow_Title
            // 
            this.Lb_DestinationRow_Title.AutoSize = true;
            this.Lb_DestinationRow_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_DestinationRow_Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_DestinationRow_Title.Location = new System.Drawing.Point(57, 121);
            this.Lb_DestinationRow_Title.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.Lb_DestinationRow_Title.Name = "Lb_DestinationRow_Title";
            this.Lb_DestinationRow_Title.Size = new System.Drawing.Size(144, 25);
            this.Lb_DestinationRow_Title.TabIndex = 8;
            this.Lb_DestinationRow_Title.Text = "Адресат:";
            this.Lb_DestinationRow_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txb_DestinationRow_Value
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Txb_DestinationRow_Value, 2);
            this.Txb_DestinationRow_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txb_DestinationRow_Value.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txb_DestinationRow_Value.Location = new System.Drawing.Point(214, 121);
            this.Txb_DestinationRow_Value.Name = "Txb_DestinationRow_Value";
            this.Txb_DestinationRow_Value.Size = new System.Drawing.Size(588, 25);
            this.Txb_DestinationRow_Value.TabIndex = 9;
            this.Txb_DestinationRow_Value.WordWrap = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel2.Controls.Add(this.TbCtrl_Main, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Send, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 152);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(943, 455);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // TbCtrl_Main
            // 
            this.TbCtrl_Main.Controls.Add(this.tabPage1);
            this.TbCtrl_Main.Controls.Add(this.tabPage2);
            this.TbCtrl_Main.Controls.Add(this.tabPage3);
            this.TbCtrl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbCtrl_Main.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbCtrl_Main.Location = new System.Drawing.Point(28, 20);
            this.TbCtrl_Main.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.TbCtrl_Main.Name = "TbCtrl_Main";
            this.TbCtrl_Main.SelectedIndex = 0;
            this.TbCtrl_Main.Size = new System.Drawing.Size(886, 353);
            this.TbCtrl_Main.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Txb_MailBody);
            this.tabPage1.Controls.Add(this.Lbl_MailSubject);
            this.tabPage1.Controls.Add(this.Txb_MailSubject);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(878, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Письмо";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Txb_MailBody
            // 
            this.Txb_MailBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_MailBody.Location = new System.Drawing.Point(3, 39);
            this.Txb_MailBody.Multiline = true;
            this.Txb_MailBody.Name = "Txb_MailBody";
            this.Txb_MailBody.Size = new System.Drawing.Size(869, 281);
            this.Txb_MailBody.TabIndex = 2;
            // 
            // Lbl_MailSubject
            // 
            this.Lbl_MailSubject.AutoSize = true;
            this.Lbl_MailSubject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_MailSubject.Location = new System.Drawing.Point(15, 10);
            this.Lbl_MailSubject.Name = "Lbl_MailSubject";
            this.Lbl_MailSubject.Size = new System.Drawing.Size(43, 19);
            this.Lbl_MailSubject.TabIndex = 0;
            this.Lbl_MailSubject.Text = "Тема:";
            this.Lbl_MailSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txb_MailSubject
            // 
            this.Txb_MailSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_MailSubject.Location = new System.Drawing.Point(64, 8);
            this.Txb_MailSubject.Name = "Txb_MailSubject";
            this.Txb_MailSubject.Size = new System.Drawing.Size(808, 25);
            this.Txb_MailSubject.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(878, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(878, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Btn_Send
            // 
            this.Btn_Send.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Send.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Send.Location = new System.Drawing.Point(804, 379);
            this.Btn_Send.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Btn_Send.MinimumSize = new System.Drawing.Size(100, 30);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(100, 30);
            this.Btn_Send.TabIndex = 1;
            this.Btn_Send.Text = "Отправить";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Btn_ChangePort
            // 
            this.Btn_ChangePort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_ChangePort.Location = new System.Drawing.Point(728, 89);
            this.Btn_ChangePort.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ChangePort.Name = "Btn_ChangePort";
            this.Btn_ChangePort.Size = new System.Drawing.Size(75, 27);
            this.Btn_ChangePort.TabIndex = 2;
            this.Btn_ChangePort.Text = "изменить";
            this.Btn_ChangePort.UseVisualStyleBackColor = true;
            this.Btn_ChangePort.Click += new System.EventHandler(this.Btn_ChangePort_Click);
            // 
            // Btn_ChangeSender
            // 
            this.Btn_ChangeSender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_ChangeSender.Location = new System.Drawing.Point(728, 27);
            this.Btn_ChangeSender.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ChangeSender.Name = "Btn_ChangeSender";
            this.Btn_ChangeSender.Size = new System.Drawing.Size(75, 27);
            this.Btn_ChangeSender.TabIndex = 11;
            this.Btn_ChangeSender.Text = "изменить";
            this.Btn_ChangeSender.UseVisualStyleBackColor = true;
            this.Btn_ChangeSender.Click += new System.EventHandler(this.Btn_ChangeSender_Click);
            // 
            // Btn_ChangeHost
            // 
            this.Btn_ChangeHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_ChangeHost.Location = new System.Drawing.Point(728, 58);
            this.Btn_ChangeHost.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ChangeHost.Name = "Btn_ChangeHost";
            this.Btn_ChangeHost.Size = new System.Drawing.Size(75, 27);
            this.Btn_ChangeHost.TabIndex = 12;
            this.Btn_ChangeHost.Text = "изменить";
            this.Btn_ChangeHost.UseVisualStyleBackColor = true;
            this.Btn_ChangeHost.Click += new System.EventHandler(this.Btn_ChangeHost_Click);
            // 
            // Txb_SenderRow_Value
            // 
            this.Txb_SenderRow_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txb_SenderRow_Value.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txb_SenderRow_Value.Location = new System.Drawing.Point(214, 28);
            this.Txb_SenderRow_Value.Name = "Txb_SenderRow_Value";
            this.Txb_SenderRow_Value.ReadOnly = true;
            this.Txb_SenderRow_Value.Size = new System.Drawing.Size(509, 25);
            this.Txb_SenderRow_Value.TabIndex = 13;
            this.Txb_SenderRow_Value.WordWrap = false;
            // 
            // Txb_ClientRow_HostValue
            // 
            this.Txb_ClientRow_HostValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txb_ClientRow_HostValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txb_ClientRow_HostValue.Location = new System.Drawing.Point(214, 59);
            this.Txb_ClientRow_HostValue.Name = "Txb_ClientRow_HostValue";
            this.Txb_ClientRow_HostValue.ReadOnly = true;
            this.Txb_ClientRow_HostValue.Size = new System.Drawing.Size(509, 25);
            this.Txb_ClientRow_HostValue.TabIndex = 14;
            this.Txb_ClientRow_HostValue.WordWrap = false;
            // 
            // Txb_ClientRow_PortValue
            // 
            this.Txb_ClientRow_PortValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txb_ClientRow_PortValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txb_ClientRow_PortValue.Location = new System.Drawing.Point(214, 90);
            this.Txb_ClientRow_PortValue.Name = "Txb_ClientRow_PortValue";
            this.Txb_ClientRow_PortValue.ReadOnly = true;
            this.Txb_ClientRow_PortValue.Size = new System.Drawing.Size(509, 25);
            this.Txb_ClientRow_PortValue.TabIndex = 15;
            this.Txb_ClientRow_PortValue.WordWrap = false;
            // 
            // MailSendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 610);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MailSendForm";
            this.Text = "MailSendForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.TbCtrl_Main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Lb_SenderRow_Title;
        private System.Windows.Forms.Button Btn_ChangePort;
        private System.Windows.Forms.Label Lb_ClientRow_Title;
        private System.Windows.Forms.Label Lb_ClientRow_Port;
        private System.Windows.Forms.Label Lb_DestinationRow_Title;
        private System.Windows.Forms.TextBox Txb_DestinationRow_Value;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl TbCtrl_Main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.TextBox Txb_MailBody;
        private System.Windows.Forms.Label Lbl_MailSubject;
        private System.Windows.Forms.TextBox Txb_MailSubject;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Btn_ChangeSender;
        private System.Windows.Forms.Button Btn_ChangeHost;
        private System.Windows.Forms.TextBox Txb_SenderRow_Value;
        private System.Windows.Forms.TextBox Txb_ClientRow_HostValue;
        private System.Windows.Forms.TextBox Txb_ClientRow_PortValue;
    }
}