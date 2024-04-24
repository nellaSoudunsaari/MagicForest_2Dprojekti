using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Tasonvalinnan koodi, tiivistettyn‰ jokainen funktio 
// siirt‰‰ pelaajan vastaavaan sceneen
public class LevelMenu : MonoBehaviour
{
    public void PlayTutorial()
    {
        SceneManager.LoadScene("Taso1");
    }
    public void PlayLevel()
    {
        SceneManager.LoadScene("Taso2");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
