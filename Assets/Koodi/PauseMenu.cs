using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    // Palauttaa pelin kulun ja n‰ytt‰‰ pause menun
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    // Pys‰ytt‰‰ pelin kulun
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;    
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Menu");
    }

    // Aika huonosti tehtty mutta tuli kiire
    public void NextLevel()
    {
        SceneManager.LoadScene("Taso2");
        Time.timeScale = 1f;
    }
    public void NextLevel2()
    {
        SceneManager.LoadScene("Taso3");
        Time.timeScale = 1f;
    }
}
