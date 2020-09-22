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
    
    public class TestParent : Label
    {

        //public string AttachedString
        //{
        //    get { return GetAttachedString(this); }
        //    set { SetAttachedString(this, (string)value); }
        //}

        //static TestParent()
        //{
        //    DefaultStyleKeyProperty.OverrideMetadata(typeof(TestParent), new FrameworkPropertyMetadata(typeof(TestParent)));
        //}



        //public static string GetAttachedString(DependencyObject obj)
        //{
        //    return (string)obj.GetValue(AttachedStringProperty);
        //}

        //public static void SetAttachedString(DependencyObject obj, string value)
        //{
        //    obj.SetValue(AttachedStringProperty, value);
        //}

        //// Using a DependencyProperty as the backing store for AttachedString.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty AttachedStringProperty =
        //    DependencyProperty.RegisterAttached("AttachedString", typeof(string), typeof(TestParent), new FrameworkPropertyMetadata("Not Set in Parent",
        //                FrameworkPropertyMetadataOptions.Inherits, OnStringChanged));

        //private static void OnStringChanged(DependencyObject d,
        //    DependencyPropertyChangedEventArgs e)
        //{
        //    var instance = d as TestParent;
        //    if (instance == null) return;
        //    instance.OnPropertyChanged(e.OldValue, e.NewValue);
        //}

        //#region refresh
        //private static void Refresh(TestParent instance)
        //{
        //    instance.Content = string.Format("parent value:\t{0}", instance.AttachedString);
        //    foreach (var myItem in instance.MyItems)
        //    {
        //        instance.Content += string.Format("\n  child value:\t{0}\t{1}",
        //                        myItem.AttachedString, myItem.UnAttachedString);
        //    }
        //    instance.Content += string.Format("\n Attached DP References are{0} equal",
        //        TestParent.AttachedStringProperty == TestChild.AttachedStringProperty
        //        ? "" : " NOT");

        //}

        //public static void RefreshAsync(TestParent tp)
        //{
        //    tp.Dispatcher.InvokeAsync(() => Refresh(tp));
        //}

        //private void OnPropertyChanged(object oldvalue, object newvalue)
        //{
        //    if (oldvalue != null && oldvalue.Equals(newvalue)) return;
        //    RefreshAsync(this);
        //}
    }
}
