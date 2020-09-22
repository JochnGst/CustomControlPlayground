using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public class SideNavigation : ContentControl
    {
        static SideNavigation()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SideNavigation), new FrameworkPropertyMetadata(typeof(SideNavigation)));
        }

        public override void BeginInit()
        {
            MenuContent = new ObservableCollection<ListViewItem>();
            base.BeginInit();
        }




        public ObservableCollection<ListViewItem> MenuContent
        {
            get { return (ObservableCollection<ListViewItem>)GetValue(MenuContentProperty); }
            set { SetValue(MenuContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MenuContentProperty =
            DependencyProperty.Register(nameof(MenuContent), typeof(ObservableCollection<ListViewItem>), typeof(SideNavigation), 
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public int SelectedIndex
        {
            get { return (int)GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }

        public static readonly DependencyProperty SelectedIndexProperty =
            DependencyProperty.Register(nameof(SelectedIndex), typeof(int), typeof(SideNavigation), new PropertyMetadata(0));




    }
}

