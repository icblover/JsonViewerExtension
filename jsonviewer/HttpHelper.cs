using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace EPocalipse.Json.Viewer
{
    public class HttpHelper
    {
        HttpWebRequest request = null;
        public WebHeaderCollection ResponseHeaderCollection;
        
        public string GetHtml(string url)
        {
            request = WebRequest.Create(CreateUri(url)) as HttpWebRequest;
            InitRequest();
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            ResponseHeaderCollection = response.Headers;
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream,Encoding.Default);
            return reader.ReadToEnd();
        }

        public Uri CreateUri(string url)
        {
            return CreateUri(url,"http");
        }
        public Uri CreateUri(string url,string httpType)
        {
            url = url.Trim().ToLower();
            if (!url.StartsWith("http")&&!url.StartsWith("https")&&!url.StartsWith("ftp"))
            {
                url = httpType + "://" + url;
            }
            Uri uri = new Uri(url);
            return uri;
        }

        public void InitRequest()
        {
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            //request.Headers.Add("Connection=keep-alive");
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/35.0.1916.153 Safari/537.36";            
            //WebProxy proxy = new WebProxy();            
            //request.Proxy = proxy;
            //request.Credentials = new NetworkCredential("username", "password");
        }

        public Dictionary<string, string> GetResponseHeader() 
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            for (int i = 0; i < ResponseHeaderCollection.Count; i++)
            {
                dictionary.Add(ResponseHeaderCollection.Keys[i], ResponseHeaderCollection.Get(i));
            }
            return dictionary;
        }
    }

    public enum HttpProtocol
    {
        Http,
        Https,
        Ftp
    }
}
