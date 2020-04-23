using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_Pos : MonoBehaviour
{


    private void Start()
    {

    }

    //moves the Primitive 2 units a second in the forward direction
    void Update()
    {

    }

    //When the Primitive collides with the walls, it will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "heart2") {
            GameObject temp = GameObject.Find("heart2");
            temp.transform.parent = null;
            Destroy(temp.GetComponent<OVRGrabbable>());
            Destroy(temp.GetComponent<Rigidbody>());
            Destroy(temp.GetComponent<BoxCollider>());
           
            temp.transform.position = new Vector3((float)2.497449, (float)3.272327, (float)7.511413);
            temp.transform.rotation = Quaternion.Euler(0,-90,0);
            
        }
    }

    //When the Primitive exits the collision, it will change Color
    private void OnTriggerExit(Collider other)
    {
       
    }
}
