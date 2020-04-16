using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableAsteroidA : ScriptableObject
{
    // Déclaration des variables
    // ========================================
    [Tooltip("Placer ici le mesh de l'asteroid A")]
    public Mesh meshAsteroidA;
    [Tooltip("Placer ici le material de l'asteroid A")]
    public Material matAsteroidA;

    public int size = 3;
    // ========================================
}
