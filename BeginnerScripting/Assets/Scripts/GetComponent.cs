using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponent : MonoBehaviour
{
    public GameObject Objet;

    private UnScript MonScript; 

    void Start()
    {
    	MonScript = Objet.GetComponent<UnScript>();
        print("La valeur est de : " + MonScript.valeur);
        print("La valeur est de : " + Objet.GetComponent<UnScript>().valeur);
    }
}
