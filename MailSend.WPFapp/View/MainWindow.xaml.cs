﻿using CoreLib;
using MailSend.WPFapp.ViewModel;
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
        //public MailSendViewModel ViewModel { get; set; }

        #region СВОЙСТВА
        //public string PrevTab
        //{
        //    get
        //    {
        //        if (tbc_TheOne.SelectedIndex > 0)
        //            return ((TabItem)tbc_TheOne.Items[tbc_TheOne.SelectedIndex - 1]).Header.ToString();
        //        else return string.Empty;
        //    }
        //}
        //public string NextTab
        //{
        //    get
        //    {
        //        if (tbc_TheOne.SelectedIndex < tbc_TheOne.Items.Count - 1)
        //            return ((TabItem)tbc_TheOne.Items[tbc_TheOne.SelectedIndex + 1]).Header.ToString();
        //        else return string.Empty;
        //    }
        //}
        #endregion


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public MainWindow()
        {
            InitializeComponent();
            //DataContext = ViewModel = new MailSendViewModel();
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


        protected void btn_SenderChangeStart_Click(object sender, RoutedEventArgs e) => mainViewModel.ChangeProcessStart(txb_Sender, "SenderSet", "SenderChange");
        protected void btn_SenderChangeCancel_Click(object sender, RoutedEventArgs e) => mainViewModel.ChangeVisibility("SenderChange", "SenderSet", TheGrid);
        protected void btn_SenderChangeTry_Click(object sender, RoutedEventArgs e)
        {
            if (mainViewModel.ChangeProcessTry(txb_Sender, mainViewModel._model.SetSender, "SenderAddress"))
                mainViewModel.ChangeVisibility("SenderChange", "SenderSet", TheGrid);
        }

        protected void btn_ClientChangeStart_Click(object sender, RoutedEventArgs e) => mainViewModel.ChangeProcessStart(txb_Client, "ClientSet", "ClientChange");
        protected void btn_ClientChangeCancel_Click(object sender, RoutedEventArgs e) => mainViewModel.ChangeVisibility("ClientChange", "ClientSet", TheGrid);
        protected void btn_ClientChangeTry_Click(object sender, RoutedEventArgs e)
        {
            if (mainViewModel.ChangeProcessTry(txb_Client, mainViewModel._model.SetClientHost, "Client"))
                mainViewModel.ChangeVisibility("ClientChange", "ClientSet", TheGrid);
        }

        protected void btn_PortChangeStart_Click(object sender, RoutedEventArgs e) => mainViewModel.ChangeProcessStart(txb_Port, "PortSet", "PortChange");
        protected void btn_PortChangeCancel_Click(object sender, RoutedEventArgs e) => mainViewModel.ChangeVisibility("PortChange", "PortSet", TheGrid);
        protected void btn_PortChangeTry_Click(object sender, RoutedEventArgs e)
        {
            if (mainViewModel.ChangeProcessTry(txb_Port, mainViewModel._model.SetClientPort, "Port"))
                mainViewModel.ChangeVisibility("PortChange", "PortSet", TheGrid);
        }
    }
}
