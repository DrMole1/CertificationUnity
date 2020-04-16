using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
	int MaxRange = 5;
    // Start is called before the first frame update
    void Start()
    {
    	//!!!!!!!!!!!!!!!!!
    	// Pour run une de ces 4 fonctions, merci de bien vouloir enlever les commentaires !
    	//!!!!!!!!!!!!!!!!!


        //BouclePour();
        //BoucleTantQue();
        //BoucleRepeter();
        BouclePourChaque();
    }

    void BouclePour()
    {
    	for (int i=0; i<=MaxRange; i++)
    	{
    		print("Le compte est de : " + i);
    	}
    }

    void BoucleTantQue()
    {
    	int i = MaxRange;
    	while(i>=0)
    	{
    		print("Ce n'est pas encore fini ! " + i);
    		i--;
    	}
    }

    void BoucleRepeter()
    {
    	int i = 0;
    	do{
    		print("Ce n'est pas encore terminé ! " + i);
    		i++;
    	}while(i<=MaxRange);
    }

    void BouclePourChaque()
    {
    	string[] strings = new string[3];
        
        strings[0] = "Banane";
        strings[1] = "Pêche";
        strings[2] = "Nature";
        
        foreach(string item in strings)
        {
            print (item);
        }
    }


}
