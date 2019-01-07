using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    private Rigidbody2D rb;

    public float speed;
    private float moveInputHorizonal;
    private float moveInputVertical;

    private bool facingRight = false;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        moveInputHorizonal = Input.GetAxis("Horizontal");
        moveInputVertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(moveInputHorizonal * speed, moveInputVertical * speed); //calculating the coordinates in real time

        if(facingRight == false && moveInputHorizonal > 0)
        {
            Flip();
        }
        else if(facingRight == true && moveInputHorizonal < 0)
        {
            Flip();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    void Flip()
    {
        facingRight = !facingRight; //changing the boolean value
        Vector3 Scaler = transform.localScale; //retrive values from unity
        Scaler.x *= -1; //multiplication sum to switch between positive and negative 
        transform.localScale = Scaler; //set new values in unity
    }

}
