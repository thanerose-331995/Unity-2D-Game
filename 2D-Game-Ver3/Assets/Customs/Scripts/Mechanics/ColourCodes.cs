using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourCodes : MonoBehaviour {

    public static Color32 objectcode;
    public bool inTrigger = false;

    //colours
    public static Color32 colourPurple, colourRed, colourBlue, colourYellow, colourOrange, colourGreen;

    void OnTriggerEnter2D(Collider2D other)
    {
        inTrigger = true;
        if (other.tag == "purple")
        {
            objectcode = colourPurple;
        }
        else if (other.tag == "red")
        {
            objectcode = colourRed;
        }
        else if (other.tag == "blue")
        {
            objectcode = colourBlue;
        }
        else if (other.tag == "yellow")
        {
            objectcode = colourYellow;
        }
        else if (other.tag == "green")
        {
            objectcode = colourGreen;
        }
        else if (other.tag == "orange")
        {
            objectcode = colourOrange;
        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        inTrigger = false;
    }

    // Use this for initialization
    void Start () {
        objectcode = Color.black;

        colourRed = new Color32(200, 0, 20, 255);
        colourBlue = new Color32(0, 0, 255, 160);
        colourYellow = new Color32(160, 100, 0, 255);
        colourPurple = new Color32(154, 0, 111, 255);
        colourOrange = new Color32(200, 150, 0, 255);
        colourGreen = new Color32(0, 200, 0, 255);
    }
	
	// Update is called once per frame
	void Update () {
	}
}
