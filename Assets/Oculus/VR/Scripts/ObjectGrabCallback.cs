using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrabCallback : GrabCallback
{
    public new void OnGrab()
    {      //ButtonOne = A, ButtonThree = X
        Debug.Log("Inside ObjectGrabCallback lelelelelel");
    }
}
