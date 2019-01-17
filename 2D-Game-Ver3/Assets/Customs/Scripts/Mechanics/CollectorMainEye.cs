using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorMainEye : MonoBehaviour {

    public static Color32 maineye, eye1Cl, eye2Cl, thiscolour = Color.black;
    public GameObject requiredEye1, requiredEye2;
    public Color32 requiredColour;
    private Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.material.color = maineye;
    }
	
	// Update is called once per frame
	void Update () {

        eye1Cl = requiredEye1.GetComponent<Renderer>().material.color;
        eye2Cl = requiredEye2.GetComponent<Renderer>().material.color;
        Debug.Log(requiredColour);
        Debug.Log(eye1Cl);
        //if i1 OR i2 OR i3 colour == red AND i1 OR i2 OR i3 colour == blue THEN{}
        if (requiredColour.Equals(ColourCodes.colourPurple))
        {
            if ((eye1Cl.Equals(ColourCodes.colourRed) || eye2Cl.Equals(ColourCodes.colourRed)) && (eye1Cl.Equals(ColourCodes.colourBlue)) || (eye2Cl.Equals(ColourCodes.colourBlue)))
            {
                maineye = ColourCodes.colourPurple;
                thiscolour = ColourCodes.colourPurple;
                rend.material.color = maineye;
            }
        }
        else if (requiredColour.Equals(eye1Cl))
        {
            Debug.Log("door open");
            maineye = requiredColour;
            rend.material.color = maineye;
        }
    }
}
