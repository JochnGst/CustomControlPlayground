using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace CustomControlPlayground.Controls
{
    public class NavigationRail : ContentControl
    {

        static NavigationRail()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NavigationRail), new FrameworkPropertyMetadata(typeof(NavigationRail)));
        }

        public override void BeginInit()
        {
            TopContent = new ObservableCollection<ListViewItem>();
            BottomContent = new ObservableCollection<ListViewItem>();
            base.BeginInit();
        }




        public ObservableCollection<ListViewItem> TopContent
        {
            get { return (ObservableCollection<ListViewItem>)GetValue(TopContentProperty); }
            set { SetValue(TopContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TopContentProperty =
            DependencyProperty.Register(nameof(TopContent), typeof(ObservableCollection<ListViewItem>), typeof(NavigationRail),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public ObservableCollection<ListViewItem> BottomContent
        {
            get { return (ObservableCollection<ListViewItem>)GetValue(BottomContentProperty); }
            set { SetValue(BottomContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BottomContentProperty =
            DependencyProperty.Register(nameof(BottomContent), typeof(ObservableCollection<ListViewItem>), typeof(NavigationRail),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public ListViewItem SelectedItem
        {
            get { return (ListViewItem)GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register(nameof(SelectedItem), typeof(ListViewItem), typeof(NavigationRail), new PropertyMetadata(null));
    }
}
