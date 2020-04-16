using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
	public GameObject[] players;

    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        for(int nCpt=0; nCpt < players.Length; nCpt++)
        {
        	print("L'élément " + nCpt+1 + " du tableau est : " + players[nCpt].name);
        }

    }

    
}
