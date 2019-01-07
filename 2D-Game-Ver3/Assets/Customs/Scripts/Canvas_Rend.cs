using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Rend : MonoBehaviour {

    public Color32 thisColour;
    private Image img;

    private float RotateSpeed = 0.5f;
    private float Radius = 150f;
    private Vector2 centre;
    private float angle;

    // Use this for initialization
    void Start () {
        img = GetComponent<Image>();//access the colour

        centre = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        thisColour = Eye_colour.altColour;
        if (Input.GetKeyDown("e"))
        {
            img.color = thisColour;
        }

        angle += RotateSpeed * Time.deltaTime;

        var offset = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle)) * Radius;
        this.img.transform.position = centre + offset;

    }
    
}
