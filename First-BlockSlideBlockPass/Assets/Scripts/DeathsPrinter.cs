using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathsPrinter : MonoBehaviour
{

    public Text deathsText;

    // Update is called once per frame
    void Update()
    {
        string deathCounts = "Deaths:\n" + "Level01 - " + PlayerPrefs.GetInt("DeathsLevel001", 0) + " , Level02 - " +
                                PlayerPrefs.GetInt("DeathsLevel002", 0) + " , Level03 - " + PlayerPrefs.GetInt("DeathsLevel003", 0) +
                                " , Level04 - " + PlayerPrefs.GetInt("DeathsLevel004", 0);
        deathsText.text = deathCounts;
    }
}
