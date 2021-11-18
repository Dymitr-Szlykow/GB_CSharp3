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

        public string SenderAddress { get => core.Sender.Address; }
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
            _ = (core = new MailSendCore()).SetSender("somemail@gmail.com", "Tom");

            Destination = "somemail@yandex.ru";
            Subject = "Тест";
            MailBody = "Письмо-тест работы smtp-клиента.";
            DataContext = this;
        }


        public void ChangeProcessStart(TextBox txb, string hide, string show)
        {
            txb.Text = "введите новое значение";
            foreach (FrameworkElement el in TheGrid.Children)
            {
                if (el.Tag?.ToString() == hide) el.Visibility = Visibility.Hidden;
                else if (el.Tag?.ToString() == show) el.Visibility = Visibility.Visible;
            }
        }
        public void ChangeProcessEnd(string hide, string show)
        {
            foreach (FrameworkElement el in TheGrid.Children)
            {
                if (el.Tag?.ToString() == hide) el.Visibility = Visibility.Hidden;
                else if (el.Tag?.ToString() == show) el.Visibility = Visibility.Visible;
            }
        }
        public bool ChangeProcessTry(TextBox txb, Predicate<string> changingMethod, string propertyName)
        {
            if (changingMethod(txb.Text))
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }
            else
            {
                txb.Text = "некорректное значение";
                return false;
            }
        }

        public void SendMail()
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


        internal void btn_SenderChangeStart_Click(object sender, RoutedEventArgs e) => ChangeProcessStart(txb_Sender, "SenderSet", "SenderChange");
        internal void btn_SenderChangeCancel_Click(object sender, RoutedEventArgs e) => ChangeProcessEnd("SenderChange", "SenderSet");
        internal void btn_SenderChangeTry_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeProcessTry(txb_Sender, core.SetSender, "SenderAddress"))
                ChangeProcessEnd("SenderChange", "SenderSet");
        }
            
        internal void btn_ClientChangeStart_Click(object sender, RoutedEventArgs e) => ChangeProcessStart(txb_Client, "ClientSet", "ClientChange");
        internal void btn_ClientChangeCancel_Click(object sender, RoutedEventArgs e) => ChangeProcessEnd("ClientChange", "ClientSet");
        internal void btn_ClientChangeTry_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeProcessTry(txb_Client, core.SetClientHost, "Client"))
                ChangeProcessEnd("ClientChange", "ClientSet");
        }

        internal void btn_PortChangeStart_Click(object sender, RoutedEventArgs e) => ChangeProcessStart(txb_Port, "PortSet", "PortChange");
        internal void btn_PortChangeCancel_Click(object sender, RoutedEventArgs e) => ChangeProcessEnd("PortChange", "PortSet");
        internal void btn_PortChangeTry_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeProcessTry(txb_Port, core.SetClientPort, "Port"))
                ChangeProcessEnd("PortChange", "PortSet");
        }

        internal void btn_Send_Click(object sender, RoutedEventArgs e) => SendMail();
    }
}
