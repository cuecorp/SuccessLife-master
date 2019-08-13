using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Newtonsoft.Json;

namespace SuccessLife
{
    public interface IBaseUrl { string Get(); }
    public class LocalHtmlBaseUrl : ContentPage
	{
		public LocalHtmlBaseUrl ()
		{
            var bo = new WebView();
           
            var urlSource = new UrlWebViewSource();
             
            string url = DependencyService.Get<IBaseUrl>().Get();
            string TempUrl = System.IO.Path.Combine(url, "login.html");
            urlSource.Url = TempUrl;
            bo.Source = urlSource;
            Content = bo;
           

        }
	}
}