using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;         // Liikkuvan tason nopeus
    public int startingPoint;   // Tason aloituskohta
    public Transform[] points;  // Tason liikeradan pisteet (mink‰ v‰lill‰ taso liikkuu)

    private int i; // index of the array (en osannut suomentaa)

    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[startingPoint].position;    // Asetetaan liikkuvan tason aloituspisteeksi
                                                                // joku m‰‰ritellyist‰ "startingPoint" pisteist‰
    }

    // Update is called once per frame
    void Update()
    {
        // Tarkistetaan tason ja pisteen et‰isyys
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i++;    // increassaa indexii
            if ( i == points.Length)    // tarkista oliko taso aikaisemalla pisteell‰ indeksin lis‰‰misen j‰lkeen
            {
                i = 0; // resetoi indeksi
            }
        }

        // Liikutetaan tasoa kohti pistett‰ jolla on indeksi "i"
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }

    // Asettaa pelaajan Collisionin liikkuvan tason parentiksi,
    // jotta pelaaja liikkuu samanaikaisesti, eli liikkuvan
    // tason p‰‰ll‰
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
