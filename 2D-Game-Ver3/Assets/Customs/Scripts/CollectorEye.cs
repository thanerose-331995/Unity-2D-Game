using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorEye : MonoBehaviour {

    private Color32 eyeColour;
    private Renderer rend;
    private bool inTrigger = false;

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
        }
    }
    
    void Start () {
        rend = GetComponent<Renderer>();
        rend.material.color = eyeColour;
    }
	
	void Update () {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.eyeColour = Eye_colour.altColour;
                rend.material.color = eyeColour;
            }
        }
    }
}
