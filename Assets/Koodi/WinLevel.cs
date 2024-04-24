using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// Lyhyt koodi, tiivistettynä hakee GameManager.cs koodista CompleteLevel()
// funktion, joka näyttää "voitto näytön" ja pysäyttää ajan,
// jotta seuraava scene lähtee pyörimään oikein

public class WinLevel : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter2D (Collider2D collision)
    {
        Time.timeScale = 0f;
        gameManager.CompleteLevel();
    }
}
