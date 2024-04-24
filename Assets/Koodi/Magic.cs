using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Pelaajan taikapallojen logiikka ja toiminta

public class Magic : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 100;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        // Asettaa pallon nopeuden ja suunnan
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        // Tarkistaa onko pallo osunut mihink‰‰n (viholliseen)
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);

        Boss boss = hitInfo.GetComponent<Boss>();
        if(boss != null)
        {
            boss.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
