using CoreLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MailSend.WPFapp.ViewModel
{
    public class MailSendViewModel : INotifyPropertyChanged
    {
        public MailSendCore _model;
        private string _NewDestination;
        private string _MailBody;
        private string _Subject;


        #region СВОЙСТВА
        public string SenderAddress { get => _model.Sender.Address; }
        public string Client { get => _model.SmtpClientHost; }
        public string Port { get => _model.SmtpClientPort.ToString(); }

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
            get => _model.Attachments;
            set => _model.Attachments = value;
        }
        public string SelectedAttachment { get; set; }
        //public IList<object> SelectedAttachments { get; set; }

        public ObservableCollection<MailAddress> Destinations
        {
            get => _model.Destinations;
            set => _model.Destinations = value;
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
        public bool NewDestinationFits { get => _model.AddressFits(NewDestination); }
        public string SelectedDestination { get; set; }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #region Комманды
        public ICommand TurnLeftCommand { get => new DelegateCommand(TurnTabLeft); }
        public ICommand TurnRightCommand { get => new DelegateCommand(TurnTabRight); }
        public ICommand AddAttachmentCommand { get => new DelegateCommand(AddAttachment); }
        public ICommand RemoveAttachmentCommand { get => new DelegateCommand(RemoveAttachment); }
        public ICommand AddRecieverCommand { get => new DelegateCommand(AddReciever); }
        public ICommand RemoveRecieverCommand { get => new DelegateCommand(RemoveReciever); }
        public ICommand SendMailCommand { get => new DelegateCommand(SendMail); }
        #endregion


        public MailSendViewModel()
        {
            _ = (_model = new MailSendCore()).SetSender("somemail@gmail.com", "Tom");

            NewDestination = string.Empty;
            Subject = "Тест";
            MailBody = "Письмо-тест работы smtp-клиента.";
        }


        public void ChangeProcessStart(TextBox txb, string tagToHide, string tagToShow)
        {
            txb.Text = "введите новое значение";
            ChangeVisibility(tagToHide, tagToShow, LogicalTreeHelper.GetParent(txb) as Panel);
        }

        public void ChangeVisibility(string tagToHide, string tagToShow, Panel inElement)
        {
            foreach (FrameworkElement el in inElement.Children)
            {
                if (el.Tag?.ToString() == tagToHide) el.Visibility = Visibility.Hidden;
                else if (el.Tag?.ToString() == tagToShow) el.Visibility = Visibility.Visible;
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


        protected void TurnTabLeft(object obj)
        {
            var element = obj as TabControl;
            if (element.SelectedIndex > 0) element.SelectedIndex--;
            else element.SelectedIndex = 0;
        }
        protected void TurnTabRight(object obj)
        {
            var element = obj as TabControl;
            if (element.SelectedIndex < element.Items.Count - 1) element.SelectedIndex++;
            else element.SelectedIndex = element.Items.Count - 1;
        }


        protected void AddAttachment(object obj)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog();
            if (dlg.ShowDialog() == true && !Attachments.Contains(dlg.FileName)) Attachments.Add(dlg.FileName);
        }

        protected void RemoveAttachment(object obj)
        {
            //if (SelectedAttachments != null)
            //    foreach (var el in SelectedAttachments) _ = Attachments.Remove(el.ToString());
            _ = Attachments.Remove(SelectedAttachment);
        }

        protected void AddReciever(object obj)
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

        protected void RemoveReciever(object obj)
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

        public void SendMail(object obj)
        {
            if (Destinations.Count > 0)
            {
                string warning = _model.SendMakingHTML(Subject, MailBody);
                _ = MessageBox.Show(warning, "отправка письма", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation);
            }
            else
            {
                _ = MessageBox.Show("не указаны получатели", "ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        #region перенести во ViewModel
        //protected void btn_SenderChangeStart_Click(object sender, RoutedEventArgs e) => ChangeProcessStart(txb_Sender, "SenderSet", "SenderChange");
        //protected void btn_SenderChangeCancel_Click(object sender, RoutedEventArgs e) => ChangeProcessEnd("SenderChange", "SenderSet");
        //protected void btn_SenderChangeTry_Click(object sender, RoutedEventArgs e)
        //{
        //    if (ChangeProcessTry(txb_Sender, core.SetSender, "SenderAddress"))
        //        ChangeProcessEnd("SenderChange", "SenderSet");
        //}

        //protected void btn_ClientChangeStart_Click(object sender, RoutedEventArgs e) => ChangeProcessStart(txb_Client, "ClientSet", "ClientChange");
        //protected void btn_ClientChangeCancel_Click(object sender, RoutedEventArgs e) => ChangeProcessEnd("ClientChange", "ClientSet");
        //protected void btn_ClientChangeTry_Click(object sender, RoutedEventArgs e)
        //{
        //    if (ChangeProcessTry(txb_Client, core.SetClientHost, "Client"))
        //        ChangeProcessEnd("ClientChange", "ClientSet");
        //}

        //protected void btn_PortChangeStart_Click(object sender, RoutedEventArgs e) => ChangeProcessStart(txb_Port, "PortSet", "PortChange");
        //protected void btn_PortChangeCancel_Click(object sender, RoutedEventArgs e) => ChangeProcessEnd("PortChange", "PortSet");
        //protected void btn_PortChangeTry_Click(object sender, RoutedEventArgs e)
        //{
        //    if (ChangeProcessTry(txb_Port, core.SetClientPort, "Port"))
        //        ChangeProcessEnd("PortChange", "PortSet");
        //}
        #endregion
    }
}
