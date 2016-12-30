using System;
using App.Base;
using App.Helper;
using Google.Protobuf;
using UnityEngine;

namespace App
{
    public class Login : HttpMonoBehaviour
    {
        private UIInput inputMobile;
        private UIInput inputCode;
        private UIButton buttonLogin;

        // Use this for initialization
        void Start()
        {
            FindBaseUis();
            inputMobile = GameObject.FindWithTag("mobile").GetComponent<UIInput>();
            inputCode = GameObject.FindWithTag("code").GetComponent<UIInput>();
            buttonLogin = GameObject.FindWithTag("login").GetComponent<UIButton>();
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void OnbtlClick()
        {
            cleanMessage();
            buttonLogin.enabled = false;
            string mobile = inputMobile.value;
            string code = inputCode.value;

            if (!RegexHelper.isMobile(mobile))
            {
                showMessage("请输入正确的手机号。");
                buttonLogin.enabled = true;
                return;
            }

            if (!RegexHelper.isValidCode(code))
            {
                showMessage("请输入正确的验证码。");
                buttonLogin.enabled = true;
                return;
            }

            LoginReq req = new LoginReq
            {
                ClientId = Constants.CLIENT_ID,
                DeviceType = DeviceHelper.getDeviceType(),
                FingerPrint = SystemInfo.deviceUniqueIdentifier,
                Mobile = mobile,
                VerificationCode = code
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
                showMessage("解析数据异常。");
            }

            if (response != null)
            {
                switch (response.Code)
                {
                    case "0":
                        {
                            DataHelper.saveProfile(response);
                            //todo jump to game index page
                            break;
                        }
                    default:
                        {
                            showMessage(response.Msg);
                            break;
                        }
                }
            }
        }
    }
}