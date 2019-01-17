using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilemapPuzzleActive : MonoBehaviour
{
    private bool inTrigger = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<CircleCollider2D>().enabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<CircleCollider2D>().enabled = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
