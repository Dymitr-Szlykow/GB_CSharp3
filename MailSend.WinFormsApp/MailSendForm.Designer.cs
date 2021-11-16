
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
            this.Lb_SenderRow_Value = new System.Windows.Forms.Label();
            this.Btn_SenerRow_change = new System.Windows.Forms.Button();
            this.Lb_ClientRow_Title = new System.Windows.Forms.Label();
            this.Lb_ClientRow_Value = new System.Windows.Forms.Label();
            this.Btn_ClientRow_change = new System.Windows.Forms.Button();
            this.Lb_ClientRow_Port = new System.Windows.Forms.Label();
            this.Lb_ClientRow_PortValue = new System.Windows.Forms.Label();
            this.Lb_DestinationRow_Title = new System.Windows.Forms.Label();
            this.Txb_DestinationRow_Value = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TbCtrl_Main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Lbl_MailSubject = new System.Windows.Forms.Label();
            this.Tbx_MailSubject = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.Lb_SenderRow_Value, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_SenerRow_change, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lb_ClientRow_Title, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Lb_ClientRow_Value, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_ClientRow_change, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Lb_ClientRow_Port, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Lb_ClientRow_PortValue, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Lb_DestinationRow_Title, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Txb_DestinationRow_Value, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(949, 610);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Lb_SenderRow_Title
            // 
            this.Lb_SenderRow_Title.AutoSize = true;
            this.Lb_SenderRow_Title.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lb_SenderRow_Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_SenderRow_Title.Location = new System.Drawing.Point(57, 29);
            this.Lb_SenderRow_Title.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.Lb_SenderRow_Title.Name = "Lb_SenderRow_Title";
            this.Lb_SenderRow_Title.Size = new System.Drawing.Size(144, 19);
            this.Lb_SenderRow_Title.TabIndex = 0;
            this.Lb_SenderRow_Title.Text = "Отправитель:";
            this.Lb_SenderRow_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_SenderRow_Value
            // 
            this.Lb_SenderRow_Value.AutoSize = true;
            this.Lb_SenderRow_Value.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lb_SenderRow_Value.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_SenderRow_Value.Location = new System.Drawing.Point(214, 29);
            this.Lb_SenderRow_Value.Margin = new System.Windows.Forms.Padding(3);
            this.Lb_SenderRow_Value.Name = "Lb_SenderRow_Value";
            this.Lb_SenderRow_Value.Size = new System.Drawing.Size(512, 19);
            this.Lb_SenderRow_Value.TabIndex = 1;
            this.Lb_SenderRow_Value.Text = "label1";
            this.Lb_SenderRow_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_SenerRow_change
            // 
            this.Btn_SenerRow_change.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_SenerRow_change.Location = new System.Drawing.Point(729, 28);
            this.Btn_SenerRow_change.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_SenerRow_change.Name = "Btn_SenerRow_change";
            this.Btn_SenerRow_change.Size = new System.Drawing.Size(75, 23);
            this.Btn_SenerRow_change.TabIndex = 2;
            this.Btn_SenerRow_change.Text = "изменить";
            this.Btn_SenerRow_change.UseVisualStyleBackColor = true;
            // 
            // Lb_ClientRow_Title
            // 
            this.Lb_ClientRow_Title.AutoSize = true;
            this.Lb_ClientRow_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_ClientRow_Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_ClientRow_Title.Location = new System.Drawing.Point(57, 54);
            this.Lb_ClientRow_Title.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.Lb_ClientRow_Title.Name = "Lb_ClientRow_Title";
            this.Lb_ClientRow_Title.Size = new System.Drawing.Size(144, 19);
            this.Lb_ClientRow_Title.TabIndex = 3;
            this.Lb_ClientRow_Title.Text = "Используется сервер:";
            this.Lb_ClientRow_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_ClientRow_Value
            // 
            this.Lb_ClientRow_Value.AutoSize = true;
            this.Lb_ClientRow_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_ClientRow_Value.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_ClientRow_Value.Location = new System.Drawing.Point(214, 54);
            this.Lb_ClientRow_Value.Margin = new System.Windows.Forms.Padding(3);
            this.Lb_ClientRow_Value.Name = "Lb_ClientRow_Value";
            this.Lb_ClientRow_Value.Size = new System.Drawing.Size(512, 19);
            this.Lb_ClientRow_Value.TabIndex = 4;
            this.Lb_ClientRow_Value.Text = "label1";
            this.Lb_ClientRow_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_ClientRow_change
            // 
            this.Btn_ClientRow_change.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_ClientRow_change.Location = new System.Drawing.Point(729, 51);
            this.Btn_ClientRow_change.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ClientRow_change.Name = "Btn_ClientRow_change";
            this.Btn_ClientRow_change.Size = new System.Drawing.Size(75, 25);
            this.Btn_ClientRow_change.TabIndex = 5;
            this.Btn_ClientRow_change.Text = "изменить";
            this.Btn_ClientRow_change.UseVisualStyleBackColor = true;
            // 
            // Lb_ClientRow_Port
            // 
            this.Lb_ClientRow_Port.AutoSize = true;
            this.Lb_ClientRow_Port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_ClientRow_Port.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_ClientRow_Port.Location = new System.Drawing.Point(57, 79);
            this.Lb_ClientRow_Port.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.Lb_ClientRow_Port.Name = "Lb_ClientRow_Port";
            this.Lb_ClientRow_Port.Size = new System.Drawing.Size(144, 19);
            this.Lb_ClientRow_Port.TabIndex = 6;
            this.Lb_ClientRow_Port.Text = "Порт:";
            this.Lb_ClientRow_Port.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_ClientRow_PortValue
            // 
            this.Lb_ClientRow_PortValue.AutoSize = true;
            this.Lb_ClientRow_PortValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_ClientRow_PortValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_ClientRow_PortValue.Location = new System.Drawing.Point(214, 79);
            this.Lb_ClientRow_PortValue.Margin = new System.Windows.Forms.Padding(3);
            this.Lb_ClientRow_PortValue.Name = "Lb_ClientRow_PortValue";
            this.Lb_ClientRow_PortValue.Size = new System.Drawing.Size(512, 19);
            this.Lb_ClientRow_PortValue.TabIndex = 7;
            this.Lb_ClientRow_PortValue.Text = "label1";
            this.Lb_ClientRow_PortValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_DestinationRow_Title
            // 
            this.Lb_DestinationRow_Title.AutoSize = true;
            this.Lb_DestinationRow_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lb_DestinationRow_Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lb_DestinationRow_Title.Location = new System.Drawing.Point(57, 104);
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
            this.Txb_DestinationRow_Value.Location = new System.Drawing.Point(214, 104);
            this.Txb_DestinationRow_Value.Name = "Txb_DestinationRow_Value";
            this.Txb_DestinationRow_Value.Size = new System.Drawing.Size(587, 25);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 135);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(943, 472);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // TbCtrl_Main
            // 
            this.TbCtrl_Main.Controls.Add(this.tabPage1);
            this.TbCtrl_Main.Controls.Add(this.tabPage2);
            this.TbCtrl_Main.Controls.Add(this.tabPage3);
            this.TbCtrl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbCtrl_Main.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbCtrl_Main.Location = new System.Drawing.Point(28, 21);
            this.TbCtrl_Main.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.TbCtrl_Main.Name = "TbCtrl_Main";
            this.TbCtrl_Main.SelectedIndex = 0;
            this.TbCtrl_Main.Size = new System.Drawing.Size(886, 367);
            this.TbCtrl_Main.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.Lbl_MailSubject);
            this.tabPage1.Controls.Add(this.Tbx_MailSubject);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(878, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Письмо";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(878, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_Send
            // 
            this.Btn_Send.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Send.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Send.Location = new System.Drawing.Point(804, 394);
            this.Btn_Send.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Btn_Send.MinimumSize = new System.Drawing.Size(100, 30);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(100, 30);
            this.Btn_Send.TabIndex = 1;
            this.Btn_Send.Text = "Отправить";
            this.Btn_Send.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(878, 347);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // Tbx_MailSubject
            // 
            this.Tbx_MailSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_MailSubject.Location = new System.Drawing.Point(64, 8);
            this.Tbx_MailSubject.Name = "Tbx_MailSubject";
            this.Tbx_MailSubject.Size = new System.Drawing.Size(808, 25);
            this.Tbx_MailSubject.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(869, 295);
            this.textBox1.TabIndex = 2;
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
        private System.Windows.Forms.Label Lb_SenderRow_Value;
        private System.Windows.Forms.Button Btn_SenerRow_change;
        private System.Windows.Forms.Label Lb_ClientRow_Title;
        private System.Windows.Forms.Label Lb_ClientRow_Value;
        private System.Windows.Forms.Button Btn_ClientRow_change;
        private System.Windows.Forms.Label Lb_ClientRow_Port;
        private System.Windows.Forms.Label Lb_ClientRow_PortValue;
        private System.Windows.Forms.Label Lb_DestinationRow_Title;
        private System.Windows.Forms.TextBox Txb_DestinationRow_Value;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl TbCtrl_Main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_MailSubject;
        private System.Windows.Forms.TextBox Tbx_MailSubject;
        private System.Windows.Forms.TabPage tabPage3;
    }
}