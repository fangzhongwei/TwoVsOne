
using App.Base;
using UnityEngine;

public class SetNickname : HttpMonoBehaviour
{
    private UIInput inputNickname;

	// Use this for initialization
	void Start () {
		FindBaseUis();
	    inputNickname = GameObject.FindGameObjectWithTag("inputNickname").GetComponent<UIInput>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void onClick()
    {
        string inputNicknameValue = inputNickname.value;
        if (inputNicknameValue == null || "".Equals(inputNicknameValue))
        {
            showMessage(Constants.EC_UC_NO_NICKNAME);
        }
    }

    public override void Callback(byte[] data)
    {
        showMessage(Constants.EC_PARSE_DATA_ERROR);

    }

    public override void HttpErrorCallback()
    {
    }
}
