using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    public SceneFader sceneFader;

    public void LoadNextLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        string[] sceneNames = {"MainMenu", "Level01", "Level02", "Level03", "Level04", "Level05",
                                "Level06", "Level07", "Level08", "Level09", "Level10 - Pre", "Level10"};
        string name = SceneManager.GetActiveScene().name.ToString();
        for (int i = 0; i < sceneNames.Length; i++)
        {
            if (name.Equals(sceneNames[i]))
            {
                sceneFader.FadeTo(sceneNames[i+1]);
                break;
            }
        }
    }
}
