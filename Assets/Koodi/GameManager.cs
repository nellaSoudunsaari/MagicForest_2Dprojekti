using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject WinScreen;
    public static bool GameIsPaused = false;
    public GameObject player;
    public TextMeshProUGUI ScoreText;

    // Suorittaa WinPause() funktion ja hakee tason pisteen
    public void CompleteLevel()
    {
        WinPause();
        ScoreText.text = "Score: " + player.GetComponent<ScoreScript>().scoreNumber;
    }

    // Pys‰ytt‰‰ pelin ja laittaa WinScreen:in n‰kyv‰ksi
    void WinPause()
    {
        WinScreen.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
