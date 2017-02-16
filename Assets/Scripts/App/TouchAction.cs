using System.Collections;
using System.Collections.Generic;
using App.Base;
using UnityEngine;

public class TouchAction : MonoBehaviour {


    // Update is called once per frame
    void Update () {

        //绘制射线为红色。方便调试
        //Debug.DrawLine(Target.transform.position, transform.position, Color.red);
        //Debug.DrawRay();
    }

    private void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter:" + tag);
        TouchContext.GetInstance().Add(gameObject);
    }

    private void OnMouseOver()
    {
        Debug.Log("OnMouseOver:" + tag);
    }

    private void OnMouseDrag()
    {
        Debug.Log("OnMouseDrag:" + tag);
    }

    private void OnMouseUp()
    {
        Debug.Log("OnMouseUp:" + tag);
    }

    private void OnMouseExit()
    {
        Debug.Log("OnMouseExit:" + tag);
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("OnMouseUpAsButton:" + tag);
    }
}
