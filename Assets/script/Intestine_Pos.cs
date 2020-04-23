using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intestine_Pos : MonoBehaviour
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
        if (other.name == "intestine2")
        {
            GameObject temp = GameObject.Find("intestine2");
            temp.transform.parent = null;
            Destroy(temp.GetComponent<OVRGrabbable>());
            Destroy(temp.GetComponent<Rigidbody>());
            Destroy(temp.GetComponent<BoxCollider>());

            temp.transform.position = new Vector3((float)2.507123, (float)2.740945, (float)7.513937);
            temp.transform.rotation = Quaternion.Euler(0,-90, 0);

        }
    }
}
