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

    // Itsest‰‰nselv‰‰?
    void Die()
    {
        Respawn();
    }

    // Hakee aloituskohdan ja siirt‰‰ pelaajaan sijainnin sinne
    void Respawn()
    {
        transform.position = StartPos;
    }
}
