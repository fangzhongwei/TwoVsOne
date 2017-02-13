using App.Base;
using App.Helper;
using App.VO;
using UnityEngine;

public class Game : WebSocketMonoBehaviour {

    public float timer = 1.0f;

    // Use this for initialization
	void Start ()
	{
	    //Input.multiTouchEnabled=true;
	    FindBaseUis();

	    SeatWatch watch = new SeatWatch();
	    RenderWatch(watch);
	    //StartWebSocket("ws://127.0.0.1:9000/greeter");
	}
	
	// Update is called once per frame
	void Update () {
	    // timer -= Time.deltaTime;
	    //if (timer <= 0) {
	       //Debug.Log(string.Format("Timer1 is up !!! time=${0}", Time.time));
	        //Send(Time.time.ToString().GetASCIIBytes());
	        // timer = 1.0f;
	    // }



	    if (Input.GetMouseButtonDown(0)){ // if left button pressed...
	        labelMessage.text = "GetMouseButtonDown";
	        Ray ray =Camera.main.ScreenPointToRay(Input.mousePosition);
	        RaycastHit hit;
	        if (Physics.Raycast(ray, out hit)){
	            labelMessage.text = "hit:" + hit;
	        }
	        else
	        {
	            labelMessage.text = "Not hit.";
	        }
	    }



































	}

    public override void HandleSocketResponse(SocketResponse socketResponse)
    {
        string action = socketResponse.P2;
        switch (action)
        {
            case "seatWatch":
                SeatWatch(socketResponse);
                break;
        }
    }

    void SeatWatch(SocketResponse socketResponse)
    {
        //    1: string code,
        //    2: string action,
        //    3: i64 gameId = 0,
        //    4: i32 gameType = 0,
        //    5: i32 deviceType = 0,
        //    6: string cards = "",
        //    7: string landlordCards = "",
        //    8: i32 baseAmount = 0,
        //    9: i32 multiples = 0,
        //    10: string previousNickname = "",
        //    11: i32 previousCardsCount = 0,
        //    12: string nextNickname = "",
        //    13: i32 nextCardsCount = 0,
        //    14: bool choosingLandlord = false,
        //    15: bool landlord = false,
        //    16: bool turnToPlay = false,
        //    17: string fingerPrint = "",
        SeatWatch watch = Convert(socketResponse);
        if (!ValidateSeatWatch(watch))
        {
            ShowMessage(Constants.EC_GAME_INVALID_DATA);
        }
        else
        {
            RenderWatch(watch);
        }

    }

    private bool ValidateSeatWatch(SeatWatch watch)
    {
        if (watch.deviceType != DeviceHelper.getDeviceType() || watch.fingerPrint != SystemInfo.deviceUniqueIdentifier)
        {
            return false;
        }
        return true;
    }

    private SeatWatch Convert(SocketResponse socketResponse)
    {
        SeatWatch watch = new SeatWatch();
        watch.gameId = long.Parse(socketResponse.P3);
        watch.gameType = int.Parse(socketResponse.P4);
        watch.deviceType = int.Parse(socketResponse.P5);
        watch.cards = socketResponse.P6;
        watch.landlordCards = socketResponse.P7;
        watch.baseAmount = int.Parse(socketResponse.P8);
        watch.multiples = int.Parse(socketResponse.P9);
        watch.previousNickname = socketResponse.P10;
        watch.previousCardsCount = int.Parse(socketResponse.P11);
        watch.nextNickname = socketResponse.P12;
        watch.nextCardsCount = int.Parse(socketResponse.P13);
        watch.choosingLandlord = bool.Parse(socketResponse.P14);
        watch.landlord = bool.Parse(socketResponse.P15);
        watch.turnToPlay = bool.Parse(socketResponse.P16);
        watch.fingerPrint = socketResponse.P17;

        return watch;
    }

    private GameObject cardObj;
    private void RenderWatch(SeatWatch watch)
    {
        //string[] cardArray = watch.cards.Split(Constants.CARDS_SEPERATOR);

        //AssetDatabase.LoadAssetAtPath("")
        //Object cardObj = AssetDatabase.LoadAssetAtPath("Assets/Cards/Prefabs/CardPlane/Clubs/cA.prefab", typeof(GameObject));
        GameObject obj = Resources.Load<GameObject>("Cards/Prefabs/CardPlane/Clubs/cA");
        Debug.Log("cardObj is :" + obj + ":");
        cardObj = Instantiate(obj);

        cardObj.transform.position = Vector3.zero;
        cardObj.transform.localScale = Vector3.one * 10;
        cardObj.transform.Rotate(new Vector3(-90, 0, 0));

        cardObj.transform.parent = transform;
    }
}