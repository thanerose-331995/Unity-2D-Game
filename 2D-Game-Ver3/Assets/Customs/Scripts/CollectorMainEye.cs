using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorMainEye : MonoBehaviour {

    public static Color32 maineye, eye1Cl, eye2Cl, eye3Cl, thiscolour = Color.black;
    private GameObject eye1, eye2, eye3;
    private Renderer rend;

    // Use this for initialization
    void Start () {
        eye1 = GameObject.Find("eye1");
        eye2 = GameObject.Find("eye2");
        eye3 = GameObject.Find("eye3");
        rend = GetComponent<Renderer>();
        rend.material.color = maineye;

    }
	
	// Update is called once per frame
	void Update () {

        eye1Cl = eye1.GetComponent<Renderer>().material.color;
        eye2Cl = eye2.GetComponent<Renderer>().material.color;
        eye2Cl = eye3.GetComponent<Renderer>().material.color;

        //if i1 OR i2 OR i3 colour == red AND i1 OR i2 OR i3 colour == blue THEN{}
        if ((eye1Cl.Equals(ColourCodes.colourRed) || eye2Cl.Equals(ColourCodes.colourRed) || eye3Cl.Equals(ColourCodes.colourRed)) && (eye1Cl.Equals(ColourCodes.colourBlue) || (eye2Cl.Equals(ColourCodes.colourBlue) || (eye3Cl.Equals(ColourCodes.colourBlue))))){
            maineye = ColourCodes.colourPurple;
            thiscolour = ColourCodes.colourPurple;
            rend.material.color = maineye;
            Debug.Log("test");
        }
    }
}
