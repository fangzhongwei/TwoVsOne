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
	void Start ()
	{
	    FindBaseUis();
	    ConfigRaw loadConfig = DataHelper.LoadConfig();

	    if (loadConfig.ResourceVersion == 0)
	    {
	        SimpleReq req = new SimpleReq
	        {
	            Param0 = loadConfig.Lan
	        };
	        HttpPost(Constants.COMMON_DISPATCH_URL, GUIDHelper.generate(), Constants.DEFAULT_TOKEN,
	            Constants.API_LOAD_ALL_RESOURCES, req.ToByteArray());
	    }
	    else
	    {
	        PullResourceReq req = new PullResourceReq
	        {
	            Version = Constants.CLIENT_ID,
	            Lan = loadConfig.Lan
	        };

	        HttpPost(Constants.COMMON_DISPATCH_URL, GUIDHelper.generate(), Constants.DEFAULT_TOKEN,
	            Constants.API_PULL_RESOURCES, req.ToByteArray());
	    }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Callback(byte[] data) {
        ResourceResp response = null;
        try
        {
            response = ResourceResp.Parser.ParseFrom(data);
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
                    DataHelper.saveResource(response);
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

    public override void HttpErrorCallback() {

    }
}
