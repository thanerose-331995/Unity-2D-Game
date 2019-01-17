using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePuzzleAnimation : MonoBehaviour
{
    private byte op;
    public bool flag, inTrigger;
    private Renderer rend;
    private Color32 colour;
    public GameObject player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inTrigger = true;            
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inTrigger = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        op = 0;
        colour = rend.material.color;
    }

    // Update is called once per frame
    void Update()
    {

        if (op == 225)
        {
            flag = false;
        }
        else if (op == 0)
        {
            flag = true;
        }

        if (flag)
        {
            op += 1;
        }
        else if (!flag)
        {
            op -= 1;
        }

        rend.material.color = new Color32(colour.r, colour.g, colour.b, op);

        if (inTrigger)
        {
            player.transform.position = new Vector2(10.53F, -14.48F);
        }
    }
    
}
