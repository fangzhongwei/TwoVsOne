using System;
using System.Collections;
using System.Collections.Generic;
using App.Helper;
using ConsoleApplication.Helper;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        protected void CleanMessage()
        {
            labelMessage.text = "";
        }

        protected void ShowMessage(string code)
        {
            if (code.Equals(Constants.EC_SSO_SESSION_EXPIRED))
            {
                DataHelper.CleanProfile();
                SceneManager.LoadScene("login");
                return;
            }
            if (code.Equals(Constants.EC_SSO_SESSION_REPELLED))
            {
                //SceneManager.LoadScene("login");
                return;
            }
            labelMessage.text = DataHelper.GetDescByCode(code, AppContext.GetInstance().GetLan());
        }

        public void HttpPost(string url, string traceId, string token, int actionId, byte[] data)
        {
            byte[] encodeBytes = new byte[0];
            if (data != null && data.Length > 0)
            {
                encodeBytes = DESHelper.EncodeBytes(GZipHelper.compress(data), AppContext.GetInstance().getDesKey());
            }
            StartCoroutine(Post(url, traceId, token, actionId,
                encodeBytes));
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
                ShowMessage(Constants.EC_NETWORK_UNREACHED);
                HttpErrorCallback();
            }
            else
            {
                Debug.Log("headers is :" + www.responseHeaders);
                string status = www.responseHeaders["STATUS"];
                string[] statusArray = status.Split(' ');
                int httpResponseCode = int.Parse(statusArray[1]);

                if (httpResponseCode != 200)
                {
                    ShowMessage(Constants.EC_SERVER_ERROR);
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
                            ShowMessage(Constants.EC_PARSE_DATA_ERROR);
                        }
                        if (response != null)
                        {
                            ShowMessage(response.Code);
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
        abstract public void HttpErrorCallback();
    }
}