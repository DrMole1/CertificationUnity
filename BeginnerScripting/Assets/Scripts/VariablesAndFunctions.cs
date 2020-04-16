using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
	int myInt = 5;
    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplieParDeux(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    int MultiplieParDeux(int nombre)
    {
    	int tempo=0;
        tempo = nombre*2;
        return tempo;
    }
}
