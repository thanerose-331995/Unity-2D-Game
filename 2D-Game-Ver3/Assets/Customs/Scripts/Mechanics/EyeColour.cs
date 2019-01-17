﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeColour : MonoBehaviour {

    public static Color32 altColour;
    private Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();//access the colour
        rend.material.color = altColour;
    }
	
	// Update is called once per frame
	void Update () {
        altColour = ColourCodes.objectcode;
        rend.material.color = altColour;
    }
}