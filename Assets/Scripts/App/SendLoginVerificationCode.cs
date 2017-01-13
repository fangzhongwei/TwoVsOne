using System;
using System.Collections;
using App.Base;
using App.Helper;
using Google.Protobuf;
using UnityEngine;

namespace App
{
    public class SendLoginVerificationCode : HttpMonoBehaviour
    {
        private UIInput inputMobile;
        private UIButton buttonSend;
        protected UILabel labelSend;
        private bool resend;
        private int lastChannel;

        // Use this for initialization
        void Start()
        {
            FindBaseUis();
            resend = false;
            lastChannel = 0;
            inputMobile = GameObject.FindWithTag("mobile").GetComponent<UIInput>();
            inputMobile.value = "15811111111";
            buttonSend = GameObject.FindWithTag("send").GetComponent<UIButton>();
            labelSend = GameObject.FindWithTag("sendBtnLabel").GetComponent<UILabel>();
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void OnbtlClick()
        {
            cleanMessage();
            buttonSend.enabled = false;

            string mobile = inputMobile.value;

            if (!RegexHelper.isMobile(mobile))
            {
                showMessage("请输入正确的手机号。");
                return;
            }

            SendLoginVerificationCodeReq req = new SendLoginVerificationCodeReq
            {
                DeviceType = DeviceHelper.getDeviceType(),
                FingerPrint = SystemInfo.deviceUniqueIdentifier,
                Mobile = mobile,
                Resend = resend,
                LastChannel = lastChannel
            };

            HttpPost(Constants.COMMON_DISPATCH_URL, GUIDHelper.generate(), Constants.DEFAULT_TOKEN,
                Constants.API_ID_SEND_CODE, req.ToByteArray());
        }

        public override void Callback(byte[] data) { 
            SendLoginVerificationCodeResp response = null;
            try
            {
                response = SendLoginVerificationCodeResp.Parser.ParseFrom(data);
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
                            showMessage("验证码已发送到您的手机，请查收。");
                            resend = true;
                            lastChannel = response.Channel;
                            StartCoroutine(Timer());
                            break;
                        }
                    default:
                        {
                            showMessage(response.Code);
                            buttonSend.enabled = true;
                            break;
                        }
                }
            }
        }

        IEnumerator Timer()
        {
            int remainingSeconds = 60;
            labelSend.text = string.Format("重新发送(${0}秒)", remainingSeconds);
            while (true) {
                yield return new WaitForSeconds(1.0f);
                remainingSeconds -= 1;
                if (remainingSeconds <= 0)
                {
                    labelSend.text = "获取验证码";
                    buttonSend.enabled = true;
                    cleanMessage();
                    break;
                }
                labelSend.text = string.Format("重新发送(${0}秒)", remainingSeconds);
            }
        }

        public override void HttpErrorCallback()
        {
            buttonSend.enabled = true;
        }
    }
}