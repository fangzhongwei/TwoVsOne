using System;
using App.Base;
using App.Helper;
using Google.Protobuf;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace App
{
    public class Login : HttpMonoBehaviour
    {
        private UIInput inputMobile;
        private UIInput inputCode;
        private UIButton buttonLogin;
        private UISprite spriteBackground;

        // Use this for initialization
        void Start()
        {
            FindBaseUis();
            inputMobile = GameObject.FindWithTag("mobile").GetComponent<UIInput>();
            inputCode = GameObject.FindWithTag("code").GetComponent<UIInput>();
            buttonLogin = GameObject.FindWithTag("login").GetComponent<UIButton>();
            spriteBackground = GameObject.FindWithTag("background").GetComponent<UISprite>();
            AdjustScreen();
        }

        private void AdjustScreen()
        {
            UIRoot root = GameObject.FindObjectOfType<UIRoot>();
            if (root != null)
            {
                float s = (float)root.activeHeight / Screen.height;
                int height = Mathf.CeilToInt(Screen.height * s);
                int width = Mathf.CeilToInt(Screen.width * s);
                Debug.Log("height = " + height);
                Debug.Log("width = " + width);
                spriteBackground.width = width;
                spriteBackground.height = height;
            }
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void OnbtlClick()
        {
            CleanMessage();
            buttonLogin.enabled = false;
            string mobile = inputMobile.value;
            string code = inputCode.value;

            if (mobile == null || "".Equals(mobile))
            {
                ShowMessage(Constants.EC_UC_NO_MOBILE);
                buttonLogin.enabled = true;
                return;
            }

            if (!RegexHelper.isMobile(mobile))
            {
                ShowMessage(Constants.EC_UC_INVALID_MOBILE);
                buttonLogin.enabled = true;
                return;
            }

            if (code == null || "".Equals(code))
            {
                ShowMessage(Constants.EC_UC_NO_CODE);
                buttonLogin.enabled = true;
                return;
            }

            if (!RegexHelper.isValidCode(code))
            {
                ShowMessage(Constants.EC_UC_INVALID_CODE);
                buttonLogin.enabled = true;
                return;
            }

            LoginReq req = new LoginReq
            {
                ClientId = Constants.CLIENT_ID,
                DeviceType = DeviceHelper.getDeviceType(),
                FingerPrint = SystemInfo.deviceUniqueIdentifier,
                Mobile = mobile,
                VerificationCode = code,
                Version = Constants.VERSION
            };

            HttpPost(Constants.COMMON_DISPATCH_URL, GUIDHelper.generate(), Constants.DEFAULT_TOKEN,
                Constants.API_ID_LOGIN, req.ToByteArray());
        }

        public override void Callback(byte[] data)
        {
            LoginResp response = null;
            try
            {
                response = LoginResp.Parser.ParseFrom(data);
            }
            catch (Exception)
            {
                ShowMessage(Constants.EC_PARSE_DATA_ERROR);
            }

            if (response != null)
            {
                switch (response.Code)
                {
                    case "0":
                        {
                            DataHelper.SaveProfile(response);
                            SceneManager.LoadScene("home");
                            break;
                        }
                    default:
                        {
                            ShowMessage(response.Code);
                            break;
                        }
                }
            }
        }

        public override void HttpErrorCallback()
        {
            buttonLogin.enabled = true;
        }
    }
}