using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColour : MonoBehaviour {

    public static bool objectColour;
    private bool inTrigger = false;
    public Material greyscaleMaterial, spriteMaterial;
    public GameObject spreader;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("test");
        if (other == spreader)
        {
            Debug.Log("colour");
            inTrigger = true;
        }
    }

    /*
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inTrigger = false;
            objectColour = false;
        }
    }
    */

    // Use this for initialization
    void Start () {
        gameObject.GetComponent<Renderer>().material = greyscaleMaterial;
    }
	
	// Update is called once per frame
	void Update () {
        if (inTrigger)
        {
            this.gameObject.GetComponent<Renderer>().material = spriteMaterial;
            /*
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (PlayerColour.playerColour)
                {
                    objectColour = true;
                }
            }
            if (objectColour == true)
            {
                this.gameObject.GetComponent<Renderer>().material = spriteMaterial;
            }
            */
        }
	}
}
