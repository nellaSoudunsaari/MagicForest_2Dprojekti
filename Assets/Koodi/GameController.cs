using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Vector2 StartPos;

    // Asettaa pelaajan sijainnin aloituskohdaksi (checkpoint)
    private void Start()
    {
        StartPos = transform.position;
    }

    // Tarkistaa osuuko pelaaja esteeseen
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Die();
        }
    }

    // Siirt‰‰ pelaajan aloituskohtaan kuluneen ajan ja suoritetun
    // rutiinin j‰lkeen, rutiini on m‰‰ritelty IEnumerator-funktiossa 
    void Die()
    {
        StartCoroutine(Respawn(0.25f));
    }

    // Hakee aloituskohdan ja siirt‰‰ pelaajaan sijainnin sinne pienen tauon j‰lkeen
    IEnumerator Respawn(float duration)
    {
        yield return new WaitForSeconds(duration);
        transform.position = StartPos;
    }
}
