using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class TwoButtonSwitch2 : UserControl
    {
        public static readonly DependencyProperty NameLeftProperty = DependencyProperty.Register("NameLeft", typeof(string), typeof(TwoButtonSwitch2));
        public static readonly DependencyProperty NameRightProperty = DependencyProperty.Register("NameRight", typeof(string), typeof(TwoButtonSwitch2));
        public static readonly DependencyProperty LeftCommandProperty = DependencyProperty.Register("LeftButtonCommand", typeof(ICommand), typeof(TwoButtonSwitch2));
        public static readonly DependencyProperty RightCommandProperty = DependencyProperty.Register("RightButtonCommand", typeof(ICommand), typeof(TwoButtonSwitch2));
        public static readonly DependencyProperty GeneralParameterProperty = DependencyProperty.Register("GeneralParameter", typeof(UIElement), typeof(TwoButtonSwitch2));

        public static readonly RoutedEvent LeftButtonActionEvent =
            EventManager.RegisterRoutedEvent("LeftButtonClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Button));
        public static readonly RoutedEvent RightButtonActionEvent =
            EventManager.RegisterRoutedEvent("RightButtonAction", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Button));


        public string NameLeft
        {
            get => (string)GetValue(NameLeftProperty);
            set => SetValue(NameLeftProperty, value);
        }
        public string NameRight
        {
            get => (string)GetValue(NameRightProperty);
            set => SetValue(NameRightProperty, value);
        }
        public ICommand LeftButtonCommand
        {
            get => (ICommand)GetValue(LeftCommandProperty);
            set => SetValue(LeftCommandProperty, value);
        }
        public ICommand RightButtonCommand
        {
            get => (ICommand)GetValue(RightCommandProperty);
            set => SetValue(RightCommandProperty, value);
        }
        public UIElement GeneralParameter
        {
            get => (UIElement)GetValue(GeneralParameterProperty);
            set => SetValue(GeneralParameterProperty, value);
        }

        public event RoutedEventHandler LeftButtonAction
        {
            add    => this.AddHandler(LeftButtonActionEvent, value);
            remove => this.RemoveHandler(LeftButtonActionEvent, value);
        }
        public event RoutedEventHandler RightButtonAction
        {
            add    => this.AddHandler(RightButtonActionEvent, value);
            remove => this.RemoveHandler(RightButtonActionEvent, value);
        }


        public TwoButtonSwitch2()
        {
            InitializeComponent();
            DataContext = this;
        }


        private void FireLeftClick(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            RaiseEvent(new RoutedEventArgs(LeftButtonActionEvent));
        }

        public void FireRightClick(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            RaiseEvent(new RoutedEventArgs(RightButtonActionEvent));
        }
    }
}
