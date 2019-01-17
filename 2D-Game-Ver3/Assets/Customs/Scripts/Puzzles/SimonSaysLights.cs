using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSaysLights : MonoBehaviour
{
    public static bool active = false;
    private int lightValue;
    private bool inTrigger;
    public static int counter = 0;
    private SpriteRenderer rend;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
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
        rend = this.gameObject.GetComponent<SpriteRenderer>();

        if(this.gameObject.name == "yellowlight")
        {
            this.lightValue = 1;
        }
        else if(this.gameObject.name == "orangelight")
        {
            this.lightValue = 2;
        }
        else if(this.gameObject.name == "pinklight")
        {
            this.lightValue = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (inTrigger)
            {
                if (active)
                {
                    rend.enabled = true;
                    StartCoroutine(playColour());

                    SimonSaysPuzzle.checkFlag = true;
                    SimonSaysPuzzle.playerSequence[counter] = lightValue;
                    counter++;
                }
            }
        }
    }

    private IEnumerator playColour()
    {
        yield return new WaitForSeconds(1);
        rend.enabled = false;
    }
}
