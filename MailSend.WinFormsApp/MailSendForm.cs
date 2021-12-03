using CoreLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MailSend.WinFormsApp
{
    public partial class MailSendForm : Form
    {
        public MailSendCore core;

        private bool ChangeSenderIsRunning = false;

        #region СВОЙСТВА, нужны ли?
        public string SenderAddress { get => core.Sender.Address; }
        public string Client { get => core.SmtpClientHost; }
        public string Port { get => core.SmtpClientPort.ToString(); }
        public string Destination { get; set; }
        public string MailBody { get; set; }
        public string Subject { get; set; }
        #endregion

        public MailSendForm()
        {
            InitializeComponent();
            _ = (core = new MailSendCore()).SetSender("somemail@gmail.com", "Tom");

            Txb_SenderRow_Value.Text = core.Sender.Address;
            Txb_ClientRow_HostValue.Text = core.SmtpClientHost;
            Txb_ClientRow_PortValue.Text = core.SmtpClientPort.ToString();
            Txb_DestinationRow_Value.Text = Destination = "somemail@yandex.ru";
            Txb_MailSubject.Text = Subject = "Тест";
            Txb_MailBody.Text = MailBody = "Письмо-тест работы smtp-клиента.";
        }

        public void SendMail()
        {
            if (core.SetDestination(Destination = Txb_DestinationRow_Value.Text))
            {
                string warning = core.SendMakingHTML(Subject = Txb_MailSubject.Text, MailBody = Txb_MailBody.Text);
                _ = MessageBox.Show(warning, "отправка письма", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                _ = MessageBox.Show("некорректный адрес", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ChangePropertyProcess(PropertyChangingArgs arg)
        {
            if (arg.btn.Text == "изменить") ChangePropertyStart(arg);
            else if (arg.btn.Text == "подтвердить")
            {
                if (arg.txb.Text == "назад") ChangePropertyEnd(arg);
                else ChangePropertyTry(arg);
            }
        }

        protected void ChangePropertyStart(PropertyChangingArgs arg)
        {
            arg.txb.ReadOnly = false;
            arg.txb.Text = null;
            arg.txb.PlaceholderText = "введите новое значение или \"назад\"";
            arg.btn.Text = "подтвердить";
        }

        public void ChangePropertyTry(PropertyChangingArgs arg)
        {
            if (arg.changingMethod(arg.txb.Text))
            {
                arg.txb.ReadOnly = true;
                arg.txb.PlaceholderText = null;
                arg.btn.Text = "изменить";
            }
            else
            {
                arg.txb.Text = null;
                arg.txb.PlaceholderText = "некорректное значение, введите новое или \"назад\"";
            }
        }

        public void ChangePropertyEnd(PropertyChangingArgs arg)
        {
            arg.txb.ReadOnly = true;
            arg.txb.Text = arg.backup;
            arg.txb.PlaceholderText = null;
            arg.btn.Text = "изменить";
        }

        private void Btn_Send_Click(object sender, EventArgs e) => SendMail();

        private void Btn_ChangeSender_Click(object sender, EventArgs e)
            => ChangePropertyProcess(new PropertyChangingArgs(Txb_SenderRow_Value, Btn_ChangeSender, core.Sender.Address, core.SetSender));

        private void Btn_ChangeHost_Click(object sender, EventArgs e)
            => ChangePropertyProcess(new PropertyChangingArgs(Txb_ClientRow_HostValue, Btn_ChangeHost, core.SmtpClientHost, core.SetClientHost));

        private void Btn_ChangePort_Click(object sender, EventArgs e)
            => ChangePropertyProcess(new PropertyChangingArgs(Txb_ClientRow_PortValue, Btn_ChangePort, core.SmtpClientPort.ToString(), core.SetClientPort));
    }

    public class PropertyChangingArgs
    {
        public TextBox txb;
        public Button btn;
        public string backup;
        public Predicate<string> changingMethod;

        public PropertyChangingArgs(TextBox txb, Button btn, string backup, Predicate<string> changingMethod)
        {
            this.txb = txb;
            this.btn = btn;
            this.backup = backup;
            this.changingMethod = changingMethod;
        }
    }
}
