using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string levelToLoad = "Level01";
    public SceneFader sceneFader;

    public void StartGame ()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        sceneFader.FadeTo(levelToLoad);
    }

    public void QuitGame()
    {
        Debug.Log("Exiting...");
        Application.Quit();
    }

}
