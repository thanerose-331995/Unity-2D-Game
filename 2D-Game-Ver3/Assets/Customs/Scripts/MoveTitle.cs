using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTitle : MonoBehaviour
{
    private float x;
    private bool flag = true;

    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (x >= 0.4)
        {
            flag = false;
        }
        else if (x <= -0.4)
        {
            flag = true;
        }

        if (flag)
        {
            x += 0.005F;
        }
        else if (!flag)
        {
            x -= 0.005F;
        }

        transform.position = new Vector2(x, transform.position.y);
    }
}
