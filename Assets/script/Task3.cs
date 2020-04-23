using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    public int status;
	public int smoke;
	public Transform Player;
	// Start is called before the first frame update
	void Start()
    {
        status = 0;
		smoke = 0;
    }

    // Update is called once per frame
    void Update()
    {
		{
			if (Player)
			{
				float dist = Vector3.Distance(Player.position, transform.position);
				if (dist < 1)
				{
					if (OVRInput.GetDown(OVRInput.Button.One))
					{
						status = 1;
						smoke = 1;
					}
				}

			}
		}

	}
}

