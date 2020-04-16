using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeStart : MonoBehaviour
{
	int nb = 0;
    // S'appelle pour les initialisations
    void Awake()
    {
        nb = 5;
    }

    // Dès la première frame
    void Start()
    {
        print("nb : " + nb);
    }
}
