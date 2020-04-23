using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoking : MonoBehaviour
{
    private MeshRenderer msRender;
    private float smooth = 0.05f;
    public Task3 button;

    void Start()
    {
        msRender = GetComponent<MeshRenderer>();


    }

    void Update()
    {
        if (button.smoke == 1)
        {
            msRender.material.color = Color.Lerp(msRender.material.color, Color.black, smooth * Time.deltaTime);
        }
    }
}