using System;
using App.Base;
using App.Helper;
using Google.Protobuf;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine;
using App.Base;

public class Index : HttpMonoBehaviour
{
	// Use this for initialization
	void Start () {



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
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Callback(byte[] data) {

    }
    public override void HttpErrorCallback() {

    }
}
