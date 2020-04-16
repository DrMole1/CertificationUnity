using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixed : MonoBehaviour
{
    //besoin d'enlever les commentaires pour tester
    // Pour gérer la physique
    void FixedUpdate()
    {
        //Debug.Log("Timer du fixed update : " + Time.deltaTime);
    }

    // Pour gérer les inputs, simple timer
    void Update()
    {
        //Debug.Log("Timer du update : " + Time.deltaTime);
    }
}
