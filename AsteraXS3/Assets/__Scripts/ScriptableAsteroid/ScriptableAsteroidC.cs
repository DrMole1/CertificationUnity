using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableAsteroidC : ScriptableObject
{
    // Déclaration des variables
    // ========================================
    [Tooltip("Placer ici le mesh de l'asteroid C")]
    public Mesh meshAsteroidC;
    [Tooltip("Placer ici le material de l'asteroid C")]
    public Material matAsteroidC;

    public int size = 1;
    // ========================================
}
