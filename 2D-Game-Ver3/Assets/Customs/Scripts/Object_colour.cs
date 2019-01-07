using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_colour : MonoBehaviour {

    public static bool objectColour;
    private bool inTrigger = false;
    public Material greyscaleMaterial;
    public Material spriteMaterial;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inTrigger = true;
        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inTrigger = false;
            objectColour = false;
        }
    }


    // Use this for initialization
    void Start () {
        gameObject.GetComponent<Renderer>().material = greyscaleMaterial;
    }
	
	// Update is called once per frame
	void Update () {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (Player_colour.playerColour)
                {
                    objectColour = true;
                }
            }
            if (objectColour == true)
            {
                this.gameObject.GetComponent<Renderer>().material = spriteMaterial;
            }
        }
	}
}
