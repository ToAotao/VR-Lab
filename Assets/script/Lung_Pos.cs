using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lung_Pos : MonoBehaviour
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
        if (other.name == "lung2")
        {
            GameObject temp = GameObject.Find("lung2");
            temp.transform.parent = null;
            Destroy(temp.GetComponent<OVRGrabbable>());
            Destroy(temp.GetComponent<Rigidbody>());
            Destroy(temp.GetComponent<BoxCollider>());

            temp.transform.position = new Vector3((float)2.513081, (float)3.236023, (float)7.517445);
            temp.transform.rotation = Quaternion.Euler(0, -90, 0);

        }
    }
}
