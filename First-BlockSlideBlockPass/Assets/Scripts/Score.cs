using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        int level = SceneManager.GetActiveScene().buildIndex;
        if (level == 1)
        {
            scoreText.text = "LEVEL 1\nPROGRESS: " + player.position.z.ToString("0");
        }
        else if (level == 2)
        {
            scoreText.text = "LEVEL 2\nPROGRESS: " + player.position.z.ToString("0");
        }
        else if (level == 3)
        {
            scoreText.text = "LEVEL 3\nPROGRESS: " + player.position.z.ToString("0");
        }
        else if (level == 4)
        {
            scoreText.text = "LEVEL 4\nPROGRESS: " + player.position.z.ToString("0");
        }
        else if (level == 5)
        {
            scoreText.text = "LEVEL 5\nPROGRESS: " + player.position.z.ToString("0");
        }
        else if (level == 6)
        {
            scoreText.text = "LEVEL 6\nPROGRESS: " + player.position.z.ToString("0");
        }
        else if (level == 7)
        {
            scoreText.text = "LEVEL 7\nPROGRESS: " + player.position.z.ToString("0");
        }
        else if (level == 8)
        {
            scoreText.text = "LEVEL 8\nPROGRESS: " + player.position.z.ToString("0");
        }
        else if (level == 9)
        {
            scoreText.text = "LEVEL 9\nPROGRESS: " + player.position.z.ToString("0");
        }
        else if (level == 10)
        {
            scoreText.text = "In the next level, not all are obstacles\n" +
                                "Only the black ones will kill you\n" +
                                "The rest will slow you down!\n" +
                                "Like the black one that will\napear after the big Blue X\n" +
                                "Avoid it in order to get to the next level!";
        }
        else if (level == 11)
        {
            scoreText.text = "LEVEL 10\nPROGRESS: " + player.position.z.ToString("0");
        }
        /*else
        {
            scoreText.text = player.position.z.ToString("0");
        }*/
    }
}
