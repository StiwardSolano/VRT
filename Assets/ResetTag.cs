using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTag : MonoBehaviour
{
    private float timer = 0;
    private float timerMax = 0;
    public bool IsEnabled = true;
    void Start()
    {
        //Debug.Log("Reseting all tags after 6 seconds ");
    }

    private bool Waited(float seconds)
    {
        timerMax = seconds;
        timer += Time.deltaTime;

        if (timer >= timerMax)
        {
            return true; //max reached - waited x - seconds
        }
        return false;
    }

    public bool ExecuteRest(bool IsRequieredToResetTag)
    {
        IsEnabled = IsRequieredToResetTag;

        return IsEnabled;
    }

    void Update()
    {
        if (!IsEnabled) return; //prevents anything happening after this line
        Debug.Log("Am I working?");
        if (!Waited(2)) return;
        Debug.Log("Orignal tag: " + gameObject.tag);
        gameObject.tag = "Untagged";
        Debug.Log("Tag changed, validate: " + gameObject.tag);
    }
}
