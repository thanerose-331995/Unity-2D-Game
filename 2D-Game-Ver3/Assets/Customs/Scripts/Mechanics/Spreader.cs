using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spreader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x < 50)
        {
            transform.localScale += new Vector3(0.05F, 0, 0);
        }
    }
}
