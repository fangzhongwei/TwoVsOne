using System;
using App.Helper;
using ConsoleApplication.Helper;
using UnityEngine;
using UnityEngine.SceneManagement;
using BestHTTP;

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

        public void HttpPost(string uri, string traceId, string token, int actionId, byte[] data)
        {
            byte[] encodeBytes = new byte[0];
            if (data != null && data.Length > 0)
            {
                encodeBytes = DESHelper.EncodeBytes(GZipHelper.compress(data), AppContext.GetInstance().getDesKey());
            }
            HTTPRequest request = new HTTPRequest(new Uri(uri), HTTPMethods.Post, OnRequestFinished);
            request.SetHeader("TI", traceId);
            request.SetHeader("AI", actionId.ToString());
            request.SetHeader("TK", token);
            request.ConnectTimeout = TimeSpan.FromSeconds(30);
            request.RawData = encodeBytes;
            request.Send();
        }

        void OnRequestFinished(HTTPRequest req, HTTPResponse resp)
        {
            Debug.Log("Request Finished! Text received: " + resp.DataAsText);
            switch (req.State)
            {
                // The request finished without any problem.
                case HTTPRequestStates.Finished:
                    if (resp.StatusCode == 200)
                    {
                        bool isNormal = "true".Equals(resp.Headers["NORMAL"]);
                        byte[] protoBytes = GZipHelper.Decompress(DESHelper.DecodeBytes(resp.Data, AppContext.GetInstance().getDesKey()));
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
                    else
                    {
                        ShowMessage(Constants.EC_SERVER_ERROR);
                    }
                    break;

                // The request finished with an unexpected error.
                // The request's Exception property may contain more information about the error.
                case HTTPRequestStates.Error:
                    Debug.LogError("Request Finished with Error! " +
                                   (req.Exception != null ?
                                       (req.Exception.Message + "\n" + req.Exception.StackTrace) :
                                       "No Exception"));
                    ShowMessage(Constants.EC_NETWORK_UNREACHED);
                    HttpErrorCallback();
                    break;

                // The request aborted, initiated by the user.
                case HTTPRequestStates.Aborted:
                    Debug.LogWarning("Request Aborted!");
                    ShowMessage(Constants.EC_NETWORK_UNREACHED);
                    HttpErrorCallback();
                    break;

                // Ceonnecting to the server timed out.
                case HTTPRequestStates.ConnectionTimedOut:
                    Debug.LogError("Connection Timed Out!");
                    ShowMessage(Constants.EC_NETWORK_TIMEOUT);
                    HttpErrorCallback();
                    break;

                // The request didn't finished in the given time.
                case HTTPRequestStates.TimedOut:
                    Debug.LogError("Processing the request Timed Out!");
                    ShowMessage(Constants.EC_NETWORK_TIMEOUT);
                    HttpErrorCallback();
                    break;
                default:
                    Debug.LogError("Connection Error!");
                    ShowMessage(Constants.EC_NETWORK_TIMEOUT);
                    HttpErrorCallback();
                    break;
            }
        }

        abstract public void Callback(byte[] data);
        abstract public void HttpErrorCallback();
    }
}