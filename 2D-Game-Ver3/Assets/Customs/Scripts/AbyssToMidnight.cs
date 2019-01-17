using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbyssToMidnight : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Transition.flag = 2;
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
