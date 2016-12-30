using System.Collections;
using System.Collections.Generic;
using ConsoleApplication.Helper;
using UnityEngine;

namespace App.Base
{
    public abstract class HttpMonoBehaviour: MonoBehaviour
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
            StartCoroutine(Post(url, traceId,  token, actionId, DESHelper.EncodeBytes(GZipHelper.compress(data), AppContext.GetInstance().getDesKey())));
        }

        IEnumerator Post(string url, string traceId, string token,  int actionId, byte[] data) {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("TI", traceId);
            headers.Add("AI", actionId.ToString());
            headers.Add("TK", token);
            WWW www = new WWW(url, data, headers);  
            yield return www;  
            if (www.error != null)
            {
                Debug.Log("error is :"+ www.error);
                Callback(false, www.bytes, www.error);
            }
            else
            {
                Debug.Log("request result :" + www.text);
                Callback(true, www.bytes, "");
            }
        }

        abstract public void Callback(bool success, byte[] data, string errorMessage);
    }
}