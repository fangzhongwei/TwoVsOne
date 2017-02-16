﻿using App.Base;
using Boo.Lang;
using HedgehogTeam.EasyTouch;
using UnityEngine;

public class TouchManager : MonoBehaviour {
    protected UILabel labelMessage;

    // Use this for initialization
    void Start () {
        labelMessage = GameObject.FindWithTag("message").GetComponent<UILabel>();
    }

    // Update is called once per frame
	void Update () {
	    Debug.Log("working..." + Input.touchCount);
	    labelMessage.text = "touch count:" + Input.touchCount;
	    if (Input.touchCount > 0)
	    {
	        if (Input.touches[0].phase == TouchPhase.Began)
	        {
	            Debug.Log("touch begin...");
	            TouchContext.GetInstance().touching = true;
	        }
	        else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
	        {
	            Debug.Log("touch end...");

	            foreach (GameObject gameObject in  TouchContext.GetInstance().TouchedList())
	            {

	                Debug.Log("touched objet : " + gameObject.tag + ", ready:" + gameObject.GetComponent<CardAttr>().ready);
	                if (gameObject.GetComponent<CardAttr>().ready)
	                {
	                    gameObject.transform.position += Vector3.down;
	                }
	                else
	                {
	                    gameObject.transform.position += Vector3.up;
	                }
	                gameObject.GetComponent<CardAttr>().ready = !gameObject.GetComponent<CardAttr>().ready;
	            }

	            TouchContext.GetInstance().touching = false;
	            TouchContext.GetInstance().Clear();
	        }
	    }
	}
}