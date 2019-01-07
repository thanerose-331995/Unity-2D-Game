using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourCodes : MonoBehaviour {

    public static Color32 objectcode;
    public bool inTrigger = false;

    //colours
    public static Color32 colourPurple;
    public static Color32 colourRed;
    public static Color32 colourBlue;
    public static Color32 colourYellow;

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
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        inTrigger = false;
    }

    // Use this for initialization
    void Start () {
        objectcode = Color.black;

        colourPurple = new Color32(154, 0, 111, 255);
        colourRed = new Color32(200, 0, 20, 255);
        colourBlue = new Color32(0, 0, 255, 160);
        colourYellow = new Color32(160, 100, 0, 255);
    }
	
	// Update is called once per frame
	void Update () {

	}
}
