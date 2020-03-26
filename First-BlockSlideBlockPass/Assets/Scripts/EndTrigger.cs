using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
    public Button pauseButton;

    void OnTriggerEnter()
    {
        pauseButton.gameObject.SetActive(false);
        gameManager.CompleteLevel();
    }

}
