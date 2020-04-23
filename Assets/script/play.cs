using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    public Task3 button;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (button.status == 1)
        {
            gameObject.GetComponent<UnityEngine.Video.VideoPlayer>().Play();
            button.status = 0;
        }
    }

}