using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSaysPuzzle : MonoBehaviour
{
    private bool startFlag = true, endFlag = false, inTrigger = false;
    public static bool checkFlag = false;
    private int count = 2, correctCount = 0;

    private int[] sequence;
    public static int[] playerSequence;

    public GameObject yellowBubble, orangeBubble, pinkBubble;
    private SpriteRenderer yellow, orange, pink;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            inTrigger = true;
            if (startFlag) //WHEN USER GOES IN START ZONE THE PUZZLE ACTIVATES
            {
                StartCoroutine(playColours(count));
                startFlag = false;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inTrigger = false;
        }
    }

        // Start is called before the first frame update
    void Start()
    {
        //ACTIVATING ARRAYS
        sequence = new int[5];
        playerSequence = new int[] { 0, 0, 0, 0, 0 };

        for(int k = 0; k < sequence.Length; k++)
        {
            sequence[k] = Random.Range(1,4); //RANDOM SEQUENCE
        }

        yellow = yellowBubble.GetComponent<SpriteRenderer>();
        orange = orangeBubble.GetComponent<SpriteRenderer>();
        pink = pinkBubble.GetComponent<SpriteRenderer>();

        yellow.enabled = false;
        orange.enabled = false;
        pink.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!endFlag)
        {
            if (SimonSaysLights.counter == count) //CHECKS FOR COUNT
            {
                if (checkFlag)
                {
                    check();
                    checkFlag = false;
                }
            }
        }
        else if (endFlag)
        {
            GameObject.Find("orangeEye").GetComponent<Renderer>().material.color = ColourCodes.colourOrange;
            yellow.enabled = true;
            orange.enabled = true;
            pink.enabled = true;
        }
    }

    void check()
    {
        for (int j = 0; j < count; j++)
        {
            //CHECK IF ARRAYS MATCH
            if(playerSequence[j] == sequence[j])
            {
                correctCount++;
            }
        }

        if(correctCount == count)
        {
            count++;

            //RESET
            if(count == 6)
            {
                endFlag = true;
            }
            else
            {
                reset();

                StartCoroutine(playColours(count));
            }
        }
        else
        {
            Debug.Log("incorrect");

            //RESET
            reset();
            count = 2;

            StartCoroutine(playColours(count));
        }
    }
    
    private IEnumerator playColours(int count)
    {
        yield return new WaitForSeconds(2);
        for (int i = 0; i < count; i++)
        {
            playSequence(i);
            yield return new WaitForSeconds(1);
            yellow.enabled = false;
            orange.enabled = false;
            pink.enabled = false;
        }
        SimonSaysLights.active = true;
    }

    private void playSequence(int i)
    {
        if (sequence[i] == 1)
        {
            yellow.enabled = true;
        }
        if (sequence[i] == 2)
        {
            orange.enabled = true;
        }
        if (sequence[i] == 3)
        {
            pink.enabled = true;
        }
    }

    private void reset()
    {
        playerSequence = new int[] { 0, 0, 0, 0, 0 };
        SimonSaysLights.counter = 0;
        correctCount = 0;
    }
}
