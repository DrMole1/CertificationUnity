using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
	public GameObject cible;
    // Enlever les commentaires pour faire fonctionner !
    void Start()
    {
        //Invoke("SpawnObjet", 5);
        //InvokeRepeating("SpawnObjet", 2, 1); //Pour répéter l'invoke
    }


    void SpawnObjet()
    {
    	Instantiate(cible,new Vector3(0,2,5), Quaternion.identity);
    }

}
