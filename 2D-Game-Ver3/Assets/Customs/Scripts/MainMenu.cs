using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Image img;
    private float op = 0;

    public void transition()
    {
        if(op < 1)
        {
            op += 0.03F;
            img.color = new Color(img.color.r, img.color.g, img.color.b, op);
        }
        else
        {
            startGame();
        }
    }
    void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
