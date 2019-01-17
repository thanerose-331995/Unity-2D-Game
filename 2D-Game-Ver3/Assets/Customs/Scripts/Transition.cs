using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public Image img;
    private float op;
    public static int flag = 0;

    // Start is called before the first frame update
    void Start()
    {
        img.color = Color.black;
        op = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        img.color = new Color(img.color.r, img.color.g, img.color.b, op);

        if (flag == 0)
        {
            if (op > 0)
            {
                op -= 0.03F;
            }
            else
            {
                flag = 1;
            }
        }

        if (flag == 2)
        {
            if (op < 1)
            {
                op += 0.03F;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

        if(currentScene.name == "Midnight")
        {
            ColourCodes.colourPurple = new Color32(150, 0, 200, 255);
            ColourCodes.objectcode = ColourCodes.colourPurple;
        }
    }
}
