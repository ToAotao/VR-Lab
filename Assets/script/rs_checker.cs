using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class rs_checker : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshPro tmp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "lung1")
        {
            tmp = (TextMeshPro)GameObject.Find("board_1_2").GetComponent<TextMeshPro>();
            tmp.text = "Lung is in the correct box.";
            tmp.color = new Color32(0, 255, 0, 255);

        }
    }

    //When the Primitive exits the collision, it will change Color
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "lung1")
        {
            tmp = (TextMeshPro)GameObject.Find("board_1_2").GetComponent<TextMeshPro>();
            tmp.text = "Lung is not in the correct box.";
            tmp.color = new Color32(255, 0, 0, 255);

        }
    }
}
