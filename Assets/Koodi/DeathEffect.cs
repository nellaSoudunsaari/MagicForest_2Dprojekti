using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEffect : MonoBehaviour
{
        void Start()
        {
        // N‰ytt‰‰ ns."kuolema-animaation"
            Invoke("EndEffect", 0.5f);
        }

        void EndEffect()
        {
        // Tuhoaa esineen EndEffectin j‰lkeen
            Destroy(gameObject);
        }
}
