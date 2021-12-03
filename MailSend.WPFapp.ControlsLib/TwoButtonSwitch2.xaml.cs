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
    public partial class TwoButtonSwitch_sophisticated : UserControl
    {
        public static readonly DependencyProperty NameLeftProperty = DependencyProperty.Register("NameLeft", propertyType: typeof(string), ownerType: typeof(TwoButtonSwitch_sophisticated));
        public static readonly DependencyProperty NameRightProperty = DependencyProperty.Register("NameRight", propertyType: typeof(string), ownerType: typeof(TwoButtonSwitch_sophisticated));
        public static readonly DependencyProperty LeftButtonClickProperty = DependencyProperty.Register("LeftButtonClick", propertyType: typeof(string), ownerType: typeof(TwoButtonSwitch_sophisticated));
        public static readonly DependencyProperty RightButtonClickProperty = DependencyProperty.Register("RightButtonClick", propertyType: typeof(string), ownerType: typeof(TwoButtonSwitch_sophisticated));
        public static readonly DependencyProperty LeftButtonCommandProperty = DependencyProperty.Register("LeftButtonCommand", propertyType: typeof(ICommand), ownerType: typeof(TwoButtonSwitch_sophisticated));
        public static readonly DependencyProperty RightButtonCommandProperty = DependencyProperty.Register("RightButtonCommand", propertyType: typeof(ICommand), ownerType: typeof(TwoButtonSwitch_sophisticated));
        public static readonly DependencyProperty CommonParameterProperty = DependencyProperty.Register("CommonParameter", propertyType: typeof(UIElement), ownerType: typeof(TwoButtonSwitch_sophisticated));

        public static readonly RoutedEvent LeftButtonClickEvent =
            EventManager.RegisterRoutedEvent("LeftButtonClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Button));
        public static readonly RoutedEvent RightButtonClickEvent =
            EventManager.RegisterRoutedEvent("RightButtonAction", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Button));


        public string NameLeft
        {
            get => GetValue(NameLeftProperty) as string;
            set => SetValue(NameLeftProperty, value);
        }
        public string NameRight
        {
            get => GetValue(NameRightProperty) as string;
            set => SetValue(NameRightProperty, value);
        }
        public event RoutedEventHandler LeftButtonClick
        {
            add => this.AddHandler(LeftButtonClickEvent, value);
            remove => this.RemoveHandler(LeftButtonClickEvent, value);
        }
        public event RoutedEventHandler RightButtonClick
        {
            add => this.AddHandler(RightButtonClickEvent, value);
            remove => this.RemoveHandler(RightButtonClickEvent, value);
        }
        public ICommand LeftButtonCommand
        {
            get => GetValue(LeftButtonCommandProperty) as ICommand;
            set => SetValue(LeftButtonCommandProperty, value);
        }
        public ICommand RightButtonCommand
        {
            get => GetValue(RightButtonCommandProperty) as ICommand;
            set => SetValue(RightButtonCommandProperty, value);
        }
        public UIElement CommonParameter
        {
            get => GetValue(CommonParameterProperty) as UIElement;
            set => SetValue(CommonParameterProperty, value);
        }


        public TwoButtonSwitch_sophisticated() => InitializeComponent();

        private void FireLeftClick(object sender, RoutedEventArgs e)
        {
            if (LeftButtonCommand != null)
                LeftButtonCommand.Execute(CommonParameter);
            else
            {
                e.Handled = true;
                RaiseEvent(new RoutedEventArgs(LeftButtonClickEvent));
            }
        }
        public void FireRightClick(object sender, RoutedEventArgs e)
        {
            if (RightButtonCommand != null)
                RightButtonCommand.Execute(CommonParameter);
            else
            {
                e.Handled = true;
                RaiseEvent(new RoutedEventArgs(RightButtonClickEvent));
            }
        }
    }
}
