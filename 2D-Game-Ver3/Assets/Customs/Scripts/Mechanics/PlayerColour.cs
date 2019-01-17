using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColour : MonoBehaviour {

    public static bool playerColour;
    private Renderer circle, eye;
    private Color colour;
    private float op;
    private bool flag = false, startFlag = false, hitTop = false;
  
    // Use this for initialization
    void Start () {
        circle = GameObject.Find("circle").GetComponent<Renderer>();
        eye = GameObject.Find("spriteEye").GetComponent<Renderer>();
        op = 0F;
        colour = new Color(eye.material.color.r, eye.material.color.g, eye.material.color.b, op);
        circle.material.color = colour;
        playerColour = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (ObjectColour.objectColour)
            {
                playerColour = true;
            }
            startFlag = true;
        }
        if (startFlag)
        {
            if (op >= 1) //runs when opacity hits 1
            {
                flag = false;
                hitTop = true;
            }
            else if(op <= 0) //runs when opacity hits 0
            {
                flag = true; //starts increase
                if (hitTop)
                {
                    startFlag = false;
                }
            }

            if (flag) //true runs increase
            {
                op += 0.05F;
            }
            else if (!flag) //false runs decrease
            {
                op -= 0.05F;
            }
        }
        colour = new Color(eye.material.color.r, eye.material.color.g, eye.material.color.b, op);
        circle.material.color = colour;
    }
}
