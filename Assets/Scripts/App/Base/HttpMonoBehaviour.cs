using System;
using System.Collections;
using System.Collections.Generic;
using ConsoleApplication.Helper;
using UnityEngine;

namespace App.Base
{
    public abstract class HttpMonoBehaviour : MonoBehaviour
    {
        protected UILabel labelMessage;

        // Use this for initialization
        protected void FindBaseUis()
        {
            labelMessage = GameObject.FindWithTag("message").GetComponent<UILabel>();
        }

        protected void cleanMessage()
        {
            labelMessage.text = "";
        }

        protected void showMessage(string message)
        {
            labelMessage.text = message;
        }

        public void HttpPost(string url, string traceId, string token, int actionId, byte[] data)
        {
            StartCoroutine(Post(url, traceId, token, actionId,
                DESHelper.EncodeBytes(GZipHelper.compress(data), AppContext.GetInstance().getDesKey())));
        }

        IEnumerator Post(string url, string traceId, string token, int actionId, byte[] data)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("TI", traceId);
            headers.Add("AI", actionId.ToString());
            headers.Add("TK", token);
            WWW www = new WWW(url, data, headers);
            yield return www;
            if (www.error != null)
            {
                Debug.Log("error is :" + www.error);
                showMessage("暂时无法连接服务器，请检查网络。");
            }
            else
            {
                Debug.Log("headers is :" + www.responseHeaders);
                string status = www.responseHeaders["STATUS"];
                string[] statusArray = status.Split(' ');
                int httpResponseCode = int.Parse(statusArray[1]);

                if (httpResponseCode != 200)
                {
                    showMessage("服务器暂时无法处理您的请求，请稍后再试。");
                }
                else
                {
                    bool isNormal = "true".Equals(www.responseHeaders["NORMAL"]);
                    byte[] protoBytes =
                        GZipHelper.Decompress(DESHelper.DecodeBytes(www.bytes, AppContext.GetInstance().getDesKey()));
                    if (!isNormal)
                    {
                        SimpleApiResponse response = null;
                        try
                        {
                            response = SimpleApiResponse.Parser.ParseFrom(protoBytes);
                        }
                        catch (Exception)
                        {
                            showMessage("解析数据异常。");
                        }
                        if (response != null)
                        {
                            showMessage(response.Msg);
                        }
                    }
                    else
                    {
                        Callback(protoBytes);
                    }
                }

            }
        }

        abstract public void Callback(byte[] data);
    }
}