using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// change scene or reload scene we are already on

public class GameManager : MonoBehaviour
{

    //bool gameHasEnded = false;
    public float restartDelya = 1f;
    public GameObject completeLevelUI;
    public Rigidbody rb;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        //if (gameHasEnded == false)
        //{
            //gameHasEnded = true;
            Debug.Log("GameOver!");
            //Invoke(NameOfFunction, TheDelayWanted);
            Invoke("Restart", restartDelya);
            //Restart();
        //}
    }

    void Restart()
    {
        updateDeaths();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//"Level01"  //SceneManager.GetActiveScene().name --> loads the last active current active scene
    }

    void updateDeaths()
    {
        int _level = SceneManager.GetActiveScene().buildIndex;
        if (_level == 1)
        {
            int counter01 = PlayerPrefs.GetInt("DeathsLevel001", 0) + 1;
            PlayerPrefs.SetInt("DeathsLevel001", counter01);
            Debug.Log("Deaths Level 01: " + counter01);
        } else if (_level == 2)
        {
            int counter02 = PlayerPrefs.GetInt("DeathsLevel002", 0) + 1;
            PlayerPrefs.SetInt("DeathsLevel002", counter02);
            Debug.Log("Deaths Level 02: " + counter02);
        }
        else if (_level == 3)
        {
            int counter03 = PlayerPrefs.GetInt("DeathsLevel003", 0) + 1;
            PlayerPrefs.SetInt("DeathsLevel003", counter03);
            Debug.Log("Deaths Level 03: " + counter03);
        }
        else if (_level == 4)
        {
            int counter04 = PlayerPrefs.GetInt("DeathsLevel004", 0) + 1;
            PlayerPrefs.SetInt("DeathsLevel004", counter04);
            Debug.Log("Deaths Level 04: " + counter04);
        }
    }

}
