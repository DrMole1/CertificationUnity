using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour
{
	//Déclaration d'une classe à la manière du php
    public class Inventaire
    {
    	public int grenouille;
    	public int grillon;
    	public int crapaud;


    	public Inventaire(int gre, int gri, int cra)
    	//Constructeur avec déclarations personnalisées
    	{
    		grenouille = gre;
    		grillon = gri;
    		crapaud = cra;
    	}

    	public Inventaire()
    	//Constructeur automatique
    	{
    		grenouille = 1;
    		grillon = 1;
    		crapaud = 1;
    	}
    }

    //Le new représente un constructor
    public Inventaire MonInventaire = new Inventaire();
    public Inventaire AutreInventaire = new Inventaire(2,3,5); //Appelle le 1er constructeur

    void Start()
    {
    	print("Nombre de grenouilles dans le 1er inventaire : " + MonInventaire.grenouille);
    	print("Nombre de grenouilles dans le 2eme inventaire : " +AutreInventaire.grenouille);
    }
}
