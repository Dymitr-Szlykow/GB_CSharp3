using CoreLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private string _NewDestination;
        private string _MailBody;
        private string _Subject;

        #region СВОЙСТВА
        public string SenderAddress { get => core.Sender.Address; }
        public string Client { get => core.SmtpClientHost; }
        public string Port { get => core.SmtpClientPort.ToString(); }

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

        public ObservableCollection<string> Attachments
        {
            get => core.Attachments;
            set => core.Attachments = value;
        }
        public string SelectedAttachment { get; set; }
        //public IList<object> SelectedAttachments { get; set; }

        public ObservableCollection<MailAddress> Destinations
        {
            get => core.Destinations;
            set => core.Destinations = value;
        }
        public string NewDestination
        {
            get => _NewDestination;
            set
            {
                _NewDestination = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NewDestination"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NewDestinationFits"));
            }
        }
        public bool NewDestinationFits { get => core.AddressFits(NewDestination); }
        public string SelectedDestination { get; set; }
        #endregion


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            _ = (core = new MailSendCore()).SetSender("somemail@gmail.com", "Tom");

            NewDestination = string.Empty;
            Subject = "Тест";
            MailBody = "Письмо-тест работы smtp-клиента.";
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
            if (Destinations.Count > 0) // core.SetDestination(Destination)
            {
                string warning = core.SendMakingHTML(Subject, MailBody);
                _ = MessageBox.Show(warning, "отправка письма", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation);
            }
            else
            {
                _ = MessageBox.Show("не указаны получатели", "ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        protected void TurnTabLeft(object sender, RoutedEventArgs e)
        {
            if (tbc_TheOne.SelectedIndex > 0) tbc_TheOne.SelectedIndex--;
            else tbc_TheOne.SelectedIndex = 0;
        }
        protected void TurnTabRight(object sender, RoutedEventArgs e)
        {
            if (tbc_TheOne.SelectedIndex < tbc_TheOne.Items.Count - 1) tbc_TheOne.SelectedIndex++;
            else tbc_TheOne.SelectedIndex = tbc_TheOne.Items.Count - 1;
        }

        protected void btn_SenderChangeStart_Click(object sender, RoutedEventArgs e) => ChangeProcessStart(txb_Sender, "SenderSet", "SenderChange");
        protected void btn_SenderChangeCancel_Click(object sender, RoutedEventArgs e) => ChangeProcessEnd("SenderChange", "SenderSet");
        protected void btn_SenderChangeTry_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeProcessTry(txb_Sender, core.SetSender, "SenderAddress"))
                ChangeProcessEnd("SenderChange", "SenderSet");
        }

        protected void btn_ClientChangeStart_Click(object sender, RoutedEventArgs e) => ChangeProcessStart(txb_Client, "ClientSet", "ClientChange");
        protected void btn_ClientChangeCancel_Click(object sender, RoutedEventArgs e) => ChangeProcessEnd("ClientChange", "ClientSet");
        protected void btn_ClientChangeTry_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeProcessTry(txb_Client, core.SetClientHost, "Client"))
                ChangeProcessEnd("ClientChange", "ClientSet");
        }

        protected void btn_PortChangeStart_Click(object sender, RoutedEventArgs e) => ChangeProcessStart(txb_Port, "PortSet", "PortChange");
        protected void btn_PortChangeCancel_Click(object sender, RoutedEventArgs e) => ChangeProcessEnd("PortChange", "PortSet");
        protected void btn_PortChangeTry_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeProcessTry(txb_Port, core.SetClientPort, "Port"))
                ChangeProcessEnd("PortChange", "PortSet");
        }

        protected void btn_Send_Click(object sender, RoutedEventArgs e) => SendMail();

        protected void btn_AddAttachment_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog();
            if (dlg.ShowDialog() == true && !Attachments.Contains(dlg.FileName)) Attachments.Add(dlg.FileName);
        }

        protected void btn_RemoveAttachment_Click(object sender, RoutedEventArgs e)
        {
            //if (SelectedAttachments != null)
            //    foreach (var el in SelectedAttachments) _ = Attachments.Remove(el.ToString());
            _ = Attachments.Remove(SelectedAttachment);
        }

        protected void btn_AddReciever_Click(object sender, RoutedEventArgs e)
        {
            bool exists = false;
            foreach (MailAddress el in Destinations)
            {
                if (el.Address == NewDestination)
                {
                    exists = true;
                    break;
                }
            }
            if (!exists) Destinations.Add(new MailAddress(NewDestination));
        }

        protected void btn_RemoveReciever_Click(object sender, RoutedEventArgs e)
        {
            for (int i = Destinations.Count - 1; i >= 0; i--)
            {
                if (Destinations[i].Address == SelectedDestination)
                {
                    Destinations.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
