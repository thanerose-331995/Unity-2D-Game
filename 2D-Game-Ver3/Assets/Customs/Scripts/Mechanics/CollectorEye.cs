using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorEye : MonoBehaviour {

    public Color32 requiredColour;
    public GameObject thisSpreader;

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
        thisSpreader.SetActive(false);
        rend = GetComponent<Renderer>();
        rend.material.color = eyeColour;
    }
	
	void Update () {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.eyeColour = EyeColour.altColour;
                rend.material.color = eyeColour;
            }
        }
        if(requiredColour.Equals(this.eyeColour))
        {
            
            thisSpreader.SetActive(true);
        }
    }
}
