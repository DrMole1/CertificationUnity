using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSafeZone : MonoBehaviour
{

    public bool IsTouchingAsteroid = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Asteroid")
        {
            IsTouchingAsteroid = true;
        }
    }
}
