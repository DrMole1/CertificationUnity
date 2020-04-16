using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableAsteroidB : ScriptableObject
{
    // Déclaration des variables
    // ========================================
    [Tooltip("Placer ici le mesh de l'asteroid B")]
    public Mesh meshAsteroidB;
    [Tooltip("Placer ici le material de l'asteroid B")]
    public Material matAsteroidB;

    public int size = 2;
    // ========================================
}
