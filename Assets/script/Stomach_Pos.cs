using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stomach_Pos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "stomach2")
        {
            GameObject temp = GameObject.Find("stomach2");
            temp.transform.parent = null;
            Destroy(temp.GetComponent<OVRGrabbable>());
            Destroy(temp.GetComponent<Rigidbody>());
            Destroy(temp.GetComponent<BoxCollider>());

            temp.transform.position = new Vector3((float)2.465225, (float)3.000761, (float)7.490052);
            temp.transform.rotation = Quaternion.Euler(0, -90, 0);

        }
    }
}
