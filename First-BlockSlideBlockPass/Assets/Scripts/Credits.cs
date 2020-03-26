using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{

    public void Quit ()
    {
        Debug.Log("QUIT?");
        Application.Quit();
        Debug.Log("QUITED!");
    }

    public void ResetDeaths ()
    {
        //PlayerPrefs.DeleteKey("PROVIDED KEY HERE");
        //PlayerPrefs.DeleteAll();  -->  Deltes all saved data
        PlayerPrefs.DeleteKey("DeathsLevel001");
        PlayerPrefs.DeleteKey("DeathsLevel002");
        PlayerPrefs.DeleteKey("DeathsLevel003");
        PlayerPrefs.DeleteKey("DeathsLevel004");
    }

}
