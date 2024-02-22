﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xNet;

namespace ChecklivedieFULL
{
    public class xNet_Helper
    {
        private HttpRequest request;
        public xNet_Helper(string cookie = "", string userAgent = "", string proxy = "", int typeProxy = 0)
        {
            if (userAgent == "")
            {
                userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.157 Safari/537.36";
            }
            request = new HttpRequest
            {
                KeepAlive = true,
                AllowAutoRedirect = true,
                Cookies = new CookieDictionary(false),
            };
            request.UserAgent = userAgent;
            //request.AddHeader("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            request.AddHeader("accept-language", "en-US,en;q=0.9");
            if (cookie != "")
            {
                AddCookie(cookie);
            }
            if (proxy != "")
            {
                if (typeProxy == 0)
                {
                    request.Proxy = HttpProxyClient.Parse(proxy);
                }
                else if (typeProxy == 1)
                {
                    request.Proxy = Socks4ProxyClient.Parse(proxy);
                }
                else if (typeProxy == 2)
                {
                    request.Proxy = Socks5ProxyClient.Parse(proxy);
                }
                else if (typeProxy == 3)
                {
                    request.Proxy = HttpProxyClient.Parse(proxy);
                }
            }
        }
        public string RequestGet(string url)
        {
            try
            {
                string source = request.Get(url).ToString();
                return source;
            }
            catch
            {
                return "Error";
            }
        }

        public byte[] GetBytes(string url)
        {
            return request.Get(url, null).ToBytes();
        }

        public string RequestPost(string url, string data = "", string contentType = "application/x-www-form-urlencoded")
        {
            try
            {
                string result;
                if (data == "" || contentType == "")
                {
                    result = request.Post(url).ToString();
                }
                else
                {
                    result = request.Post(url, data, contentType).ToString();
                }
                return result;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Не удалось соединиться"))
                {
                    return "Reload";
                }
                else
                {
                    return "Error";
                }
            }
        }
        public void AddCookie(string cookie)
        {
            string[] array = cookie.Split(new char[]
            {
                ';'
            });
            foreach (string text in array)
            {
                string[] array3 = text.Split(new char[]
                {
                    '='
                });
                if (array3.Count<string>() > 1)
                {
                    try
                    {
                        request.Cookies.Add(array3[0], array3[1]);
                    }
                    catch
                    {
                    }
                }
            }
        }
        public string GetCookie()
        {
            return request.Cookies.ToString();
        }
    }
}
