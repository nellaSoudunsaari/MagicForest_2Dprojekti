using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }
}
