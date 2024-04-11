using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // defines the camera offset from the player
    private Vector3 offset = new Vector3(0f, 0f, -10f);
    // approximate time of the camera reaching the player (camera smoothing)
    private float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;

    // setting the target the camera follows and serializes it
    [SerializeField] private Transform target;

      

    // Update is called once per frame
    void Update()
    {
        // adds the offset to the position of target to gradually change
        // a vector towards a desired goal, making the camera smoothing
        // actually available/usable
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
