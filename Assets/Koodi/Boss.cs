using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Viimeisen vihollisen scripti
// Mahdollisesti turha, en ehtinyt alkaa testaamaan

public class Boss : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;

    // Miten vihollinen ottaa vahinkoa vastaan
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
            DestroyEnemy();
        }
    }

    // Ei tuhoa esinett�, mutta suorittaa ns "kuolema-animaation"
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
    }

    // Tuhoaa esineen
    public void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}