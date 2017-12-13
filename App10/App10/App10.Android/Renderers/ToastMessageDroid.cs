﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App10.Interfaces;
using App10.Droid.Renderers;

[assembly: Xamarin.Forms.Dependency(typeof(ToastMessageDroid))]
namespace App10.Droid.Renderers
{
    public class ToastMessageDroid : IMessage
    {
        public void ShortAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
        }
        public void LongAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }
    }
}