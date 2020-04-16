using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAsteroid : MonoBehaviour
{

    // Déclaration des variables
    // =================================
    float factorX = 0f;
    float factorY = 0f;
    float factorZ = 0f;
    // =================================

    float nfactorX;
    float nfactorY;
    float nfactorZ;

    void Awake()
    {

        factorX = Random.Range(-1.2f, 1.2f);
        factorY = Random.Range(-1.2f, 1.2f);
        factorZ = Random.Range(-1.2f, 1.2f);
    }


    void Update()
    {
        

        nfactorX += factorX;
        nfactorY += factorY;
        nfactorZ += factorZ;

        DoRotation();
    }


    void DoRotation()
    {

        transform.localRotation = Quaternion.Euler(nfactorX, nfactorY, nfactorZ);
    }


}
