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

            HttpPost(Constants.COMMON_DISPATCH_URL, GUIDHelper.generate(), Constants.DEFAULT_TOKEN, Constants.API_ID_LOGIN, req.ToByteArray());
        }

        public override void Callback(bool success, byte[] data, string errorMessage)
        {
            if (!success)
            {
                showMessage("暂时无法连接服务器，请检查网络。");
            }
            else
            {
                LoginResp response = LoginResp.Parser.ParseFrom(data);
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