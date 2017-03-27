using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Fidabel
{
    public class RestService
    {
        public string GetData(string path)
        {

            try
            {

                var webAddr = path;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "get";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (Stream stream = httpResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    return reader.ReadToEnd();

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int PostData(object Json,string path)
        {

            try
            {

              
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(path);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(Json);
                    streamWriter.Flush();
                    streamWriter.Close();
                    return 0;
                }
               
            }
            catch (Exception ex)
            {
                return 1;
            }
        }

        public List<production_line> GetLine(string path)
        {
            string jsondata = GetData(path);
            if (jsondata != null)
            {
                return JsonConvert.DeserializeObject<List<production_line>>(jsondata);
            }
            return null;

        }
        public string GetLogin(string path)
        {
            string jsondata = GetData(path);
           
            return jsondata;

        }
        public List<production_order> GetOrder(string path)
        {
            try
            {
                string jsondata = GetData(path);
                if (jsondata != null)
                {
                    return JsonConvert.DeserializeObject<List<production_order>>(jsondata);
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
        }
        public production_order_detail GetOrderDetail(string path)
        {
            try
            {
                string jsondata = GetData(path);
                if (jsondata != null)
                {
                    return JsonConvert.DeserializeObject<production_order_detail>(jsondata);
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
        }
        public List<production_order_detail> GetOrderDetailList(string path)
        {
            try
            {
                string jsondata = GetData(path);
                if (jsondata != null)
                {
                    return JsonConvert.DeserializeObject<List<production_order_detail>>(jsondata);
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return null;
        }
    }
}
