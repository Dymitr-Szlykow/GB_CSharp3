using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MailSend.WPFapp.ControlsLib
{
    public partial class TwoButtonSwitch_clumsy : UserControl
    {
        public string NameLeft { get; set; }
        public string NameRight { get; set; }

        public Action<object, RoutedEventArgs> LeftButtonAction { get; set; }
        public Action<object, RoutedEventArgs> RightButtonAction { get; set; }


        public TwoButtonSwitch_clumsy()
        {
            InitializeComponent();
            DataContext = this;
        }


        private void LeftButton_Click(object sender, RoutedEventArgs e) => LeftButtonAction.Invoke(sender, e);
        private void RightButton_Click(object sender, RoutedEventArgs e) => RightButtonAction.Invoke(sender, e);
    }
}
