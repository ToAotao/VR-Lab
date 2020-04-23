using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ds_checker : MonoBehaviour
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
        if (other.name == "stomach1")
        {
            tmp = (TextMeshPro)GameObject.Find("board_1_3").GetComponent<TextMeshPro>();
            tmp.text = "Stomach is in the correct box.";
            tmp.color = new Color32(0, 255, 0, 255);

        }
        if (other.name == "intestine1") {
            tmp = (TextMeshPro)GameObject.Find("board_1_7").GetComponent<TextMeshPro>();
            tmp.text = "Intestine is in the correct box.";
            tmp.color = new Color32(0, 255, 0, 255);

        }
        if (other.name == "liver1")
        {
            tmp = (TextMeshPro)GameObject.Find("board_1_4").GetComponent<TextMeshPro>();
            tmp.text = "Intestine is in the correct box.";
            tmp.color = new Color32(0, 255, 0, 255);

        }
    }

    //When the Primitive exits the collision, it will change Color
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "stomach1")
        {
            tmp = (TextMeshPro)GameObject.Find("board_1_3").GetComponent<TextMeshPro>();
            tmp.text = "Stomach is not in the correct box.";
            tmp.color = new Color32(255,0,0,255);

        }
       if (other.name == "intestine1")
        {
            tmp = (TextMeshPro)GameObject.Find("board_1_7").GetComponent<TextMeshPro>();
            tmp.text = "Intestine is not in the correct box.";
            tmp.color = new Color32(255, 0, 0, 255);

        }
        if (other.name == "liver1")
        {
            tmp = (TextMeshPro)GameObject.Find("board_1_4").GetComponent<TextMeshPro>();
            tmp.text = "Intestine is not in the correct box.";
            tmp.color = new Color32(255, 0, 0, 255);

        }
    }
}
