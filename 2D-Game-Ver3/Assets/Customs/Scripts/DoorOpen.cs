using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

    public string desiredcolour;
    public Renderer currentcolour;
    public Animator animator;
    private Color32 thiscolour;

    // Use this for initialization
    void Start () {

        

        animator = GetComponent<Animator>();
        animator.SetBool("isOpen", false);

        if (this.desiredcolour == "purple")
        {
            this.thiscolour = ColourCodes.colourPurple;
        }

	}


	
	// Update is called once per frame
	void Update () {

        animator = GetComponent<Animator>();

		if(this.thiscolour.Equals(CollectorMainEye.thiscolour)) //THIS IS BROKEN
        {
            Debug.Log("check");
            animator.SetBool("isOpen", true);

        }

        if (animator.GetBool("isOpen") == true)
        {
            animator.Play("doormove");
        }
    }
}
