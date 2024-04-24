using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBG : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 LastCameraPosition;

    // Aseta ja hae kameran sijainti
    private void Start()
    {
        cameraTransform = Camera.main.transform;
        LastCameraPosition = cameraTransform.position;
    }

    // Tarkistaa kuinka paljon kamera on liikkunut ja asettaa kuinka paljon/nopeasti taustakuva liikkuu kameran mukana
    private void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - LastCameraPosition;
        float parallaxEffectMultiplier = .5f;
        transform.position += deltaMovement * parallaxEffectMultiplier;
        LastCameraPosition = cameraTransform.position;
    }
}
