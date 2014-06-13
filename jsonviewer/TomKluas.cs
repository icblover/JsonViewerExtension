using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace EPocalipse.Json.Viewer
{
    public class TomKluas
    {
        public static string LastUrl { get; set; }

        public static string Decode(string url)
        {
            LastUrl = string.Empty;
            return Decode(url, Encoding.UTF8);
        }

        public static string Decode(string url, Encoding encode)
        {
            if (string.IsNullOrEmpty(LastUrl))
            {
                LastUrl = HttpUtility.UrlDecode(url, encode);
            }
            if (LastUrl != HttpUtility.UrlDecode(LastUrl, encode))
            {
                LastUrl = HttpUtility.UrlDecode(LastUrl, encode);
                Decode(LastUrl, encode);
            }
            return LastUrl;
        }

        public static string DecodeOnce(string url)
        {
            return HttpUtility.UrlDecode(url);
        }

        public static List<ParameterPair> SortUrl(string urlStr)
        {
            if (!urlStr.Contains("?") && !urlStr.Contains("#"))
            {
                urlStr = "localhost?" + urlStr;
            }
            Uri url = new Uri(urlStr);
            List<ParameterPair> list = new List<ParameterPair>();
            string[] queryString = url.Query.Length > 1 ? url.Query.Substring(1).Split('&') : null;
            foreach (var keyValue in queryString)
            {
                if (!string.IsNullOrEmpty(keyValue) && !keyValue.StartsWith("_") && !keyValue.StartsWith("jsoncallback"))
                {
                    list.Add(new ParameterPair
                    {
                        Key = keyValue.Split('=')[0],
                        Value = keyValue.Split('=')[1]
                    });
                }
            }
            list = (from p in list orderby p.Key select p).ToList<ParameterPair>();
            return list;
        }
    }

    /// <summary>
    /// Url Parameter Pair
    /// </summary>
    public class ParameterPair
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
