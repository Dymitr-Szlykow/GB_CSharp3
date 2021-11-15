using CoreLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MailSend.WPFapp
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MailSendCore core;

        private string _Destination;
        private string _MailBody;
        private string _Subject;

        public string SenderAdress { get => core.Sender.Address; }
        public string Client { get => core.SmtpClientHost; }
        public string Port { get => core.SmtpClientPort.ToString(); }
        public string Destination
        {
            get => _Destination;
            set
            {
                _Destination = value;
                NotifyPropertyChanged();
            }
        }
        public string MailBody
        {
            get => _MailBody;
            set
            {
                _MailBody = value;
                NotifyPropertyChanged();
            }
        }
        public string Subject
        {
            get => _Subject;
            set
            {
                _Subject = value;
                NotifyPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public MainWindow()
        {
            InitializeComponent();
            core = new MailSendCore();
            core.SetSender("somemail@gmail.com", "Tom");
            Destination = "somemail@yandex.ru";
            Subject = "Тест";
            MailBody = "Письмо-тест работы smtp-клиента.";
            DataContext = this;
        }



        #region TODO
        internal void btn_SwitchSender_Click(object sender, RoutedEventArgs e)
        {
            core.SetSender("адресс", "имя");
        }

        internal void btn_SwitchSmtpClient_Click(object sender, RoutedEventArgs e)
        {
            core.SetSmtpClient();
        }

        internal void btn_Send_Click(object sender, RoutedEventArgs e)
        {
            if (core.SetDestination(Destination))
            {
                string warning = core.SendMakingHTML(Subject, MailBody);
                _ = MessageBox.Show(warning, "отправка письма", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation);
            }
            else
            {
                _ = MessageBox.Show("некорректный адрес", "ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion
    }
}
