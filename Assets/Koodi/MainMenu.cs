using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // N‰ytt‰‰ ensin pelin tarinan, jonka j‰lkeen lataa tasojen valinnan
        SceneManager.LoadScene("Dialogi");
    }

    // Nosiis
    public void QuitGame()
    {
        Debug.Log("Game quit");
        Application.Quit();
    }
}
