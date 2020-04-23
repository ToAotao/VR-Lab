using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cs_checker : MonoBehaviour
{
    public TextMeshPro tmp;
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
        if (other.name == "heart1")
        {
            tmp = (TextMeshPro)GameObject.Find("board_1_1").GetComponent<TextMeshPro>();
            tmp.text = "Heart is in the correct box.";
            tmp.color = new Color32(0, 255, 0, 255);

        }
    }

    //When the Primitive exits the collision, it will change Color
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "heart1")
        {
            tmp = (TextMeshPro)GameObject.Find("board_1_1").GetComponent<TextMeshPro>();
            tmp.text = "Heart is not in the correct box.";
            tmp.color = new Color32(255, 0, 0, 255);

        }
    }
}
