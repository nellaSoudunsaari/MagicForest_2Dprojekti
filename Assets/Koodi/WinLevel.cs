using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// Lyhyt koodi, tiivistettyn� hakee GameManager.cs koodista CompleteLevel()
// funktion, joka n�ytt�� "voitto n�yt�n" ja pys�ytt�� ajan,
// jotta seuraava scene l�htee py�rim��n oikein

public class WinLevel : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter2D (Collider2D collision)
    {
        Time.timeScale = 0f;
        gameManager.CompleteLevel();
    }
}
