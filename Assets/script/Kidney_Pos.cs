using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kidney_Pos : MonoBehaviour
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
        if (other.name == "kidney2")
        {
            GameObject temp = GameObject.Find("kidney2");
            temp.transform.parent = null;
            Destroy(temp.GetComponent<OVRGrabbable>());
            Destroy(temp.GetComponent<Rigidbody>());
            Destroy(temp.GetComponent<BoxCollider>());

            temp.transform.position = new Vector3((float)2.547878, (float)2.958211, (float)7.515877);
            temp.transform.rotation = Quaternion.Euler(0, -90, 0);

        }
    }
}
