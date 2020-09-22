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

namespace CustomControlPlayground.Controls
{
    public class NavigationRailItem : ListViewItem
    {
        static NavigationRailItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NavigationRailItem), new FrameworkPropertyMetadata(typeof(NavigationRailItem)));
        }



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(NavigationRailItem), new PropertyMetadata(""));


    }
}
