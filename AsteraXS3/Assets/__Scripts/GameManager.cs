using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    const float RANGEXMAX = 15f;
    const float RANGEXMIN = 5f;
    const float RANGEY = 7f;

    // Déclaration des variables
    // =============================================
    [Header("Initialisation du niveau")]
    [Range(0,11)]
    public int currentRoom = 1;
    public int nbAsteroid = 3;
    public GameObject prefabAsteroid;
    // =============================================


    void Awake()
    {
        SpawnAsteroid();
    }


    void Update()
    {
        
    }


    /// <summary>
    /// Fait apparaître les asteroides au début de partie selon des coordonnées aléatoires.
    /// </summary>
    void SpawnAsteroid()
    {
        int nbAlea = 0;
        float posX = 0.0f;
        float posY = 0.0f;

        for( int i = 0; i < nbAsteroid; i++ )
        {
            nbAlea = Random.Range(1, 2);

            if (nbAlea == 1)
                posX = Random.Range(-RANGEXMAX, -RANGEXMIN);
            else
                posX = Random.Range(RANGEXMIN, RANGEXMAX);

            posY = Random.Range(-RANGEY, RANGEY);

            GameObject instanceAsteroid;
            instanceAsteroid = Instantiate(prefabAsteroid, new Vector3(posX, posY, 0), Quaternion.identity);
        }  
    }
}
