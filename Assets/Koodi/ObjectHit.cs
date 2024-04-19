using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public GameObject hitObject;

    private void Start()
    {
        hitObject.layer = LayerMask.NameToLayer("Default");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            hitObject.SetActive(true);
        }
    }
}
