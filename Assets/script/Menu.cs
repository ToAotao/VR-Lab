using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Menu : MonoBehaviour
{
    public OVRInput.Button menu = OVRInput.Button.Start;
    private bool activity;
    public GameObject obj;   //here the object you want to disable
    void Start()
    {
        activity = false;
    }

    void Update()
    {
        obj.SetActive(activity);   //here disables the obj
        if (OVRInput.GetDown(menu))
        {
            activity = !activity;
        }
    }
}


