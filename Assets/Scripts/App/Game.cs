using App.Base;
using UnityEngine;

public class Game : WebSocketMonoBehaviour {

    public float timer = 1.0f;

    // Use this for initialization
	void Start ()
	{
	    FindBaseUis();
	    StartWebSocket("ws://172.16.7.111:9000/greeter");
	}
	
	// Update is called once per frame
	void Update () {
	    timer -= Time.deltaTime;
	    if (timer <= 0) {
	        Debug.Log(string.Format("Timer1 is up !!! time=${0}", Time.time));
	        SendString(Time.time.ToString());
	        timer = 1.0f;
	    }
	}
}
