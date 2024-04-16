using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject magicPrefab;

    // Update is called once per frame
    void Update()
    {
        // Ammusnappi (hiiren vasen nappi)
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Luo ammuksen/taikapallon
        Instantiate(magicPrefab, firePoint.position, firePoint.rotation);
    }
}
