using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_colour : MonoBehaviour {

    private Color circlecolour = Eye_colour.altColour;
    private Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.material.color = circlecolour;
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(circlecolour);
        circlecolour = Eye_colour.altColour;
        rend.material.color = circlecolour;
    }
}
