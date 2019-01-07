using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_colour : MonoBehaviour {

    public static bool playerColour;
  
    // Use this for initialization
    void Start () {
        playerColour = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Object_colour.objectColour)
            {
                playerColour = true;
            }
        }
    }
}
