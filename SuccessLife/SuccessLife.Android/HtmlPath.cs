using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using SuccessLife.Android;
using Newtonsoft.Json;

[assembly: Dependency(typeof(HtmlPath))]
namespace SuccessLife.Android
{
    class HtmlPath : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/successLife_project";
        }
    }
}