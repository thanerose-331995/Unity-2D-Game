using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirrors : MonoBehaviour {

    private bool inTrigger = false;
    private bool flag = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inTrigger = true;
            Debug.Log("player");
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inTrigger = false;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (flag)
                {
                    transform.Rotate(0, 0, 1 * 2);
                    flag = false;
                }
                else
                {
                    transform.Rotate(0, 0, 0);
                    flag = true;
                }
            }

        }
    }
}
