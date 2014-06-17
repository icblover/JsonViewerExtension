using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Text.RegularExpressions;

namespace EPocalipse.Json.Viewer

{
    public class TomKluas
    {
        public static int DecodeCount { get; set; }
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
            try
            {
                if (!urlStr.Contains("?") && !urlStr.Contains("#") && !Regex.IsMatch(urlStr, @"((https|http)\:\/\/)?([\w\-_]+\.)?([\w\-_]+\.)[\w\-_]+\.(com|cn|net|me|biz|cn|info|name|tv|cc|so|mobi|tel|asia|co|org)"))
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
                        if (keyValue.Contains("="))
                        {
                            list.Add(new ParameterPair
                            {
                                Key = keyValue.Split('=')[0],
                                Value = keyValue.Split('=')[1]
                            });    
                        }
                        else
                        {
                            list.Add(new ParameterPair
                            {
                                Key = keyValue,
                                Value = string.Empty
                            });
                        }
                    }
                }
                if (list.Count>0)
                {
                    list = (from p in list orderby p.Key select p).ToList<ParameterPair>();    
                }                
                return list;
            }
            catch (Exception ex)
            {
                return new List<ParameterPair>{new ParameterPair{
                    Key="error",Value=ex.ToString()
                }};
            }
            
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
