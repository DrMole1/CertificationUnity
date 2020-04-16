using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public int age = 5;
    
    
    void Start()
    {
        switch (age)
        {
        case 5:
            print ("Tu es à l'école");
            break;
        case 12:
            print ("Tu es un enfant");
            break;
        case 18:
            print ("Tu es majeur");
            break;
        case 40:
            print ("Crise de la quarantaine");
            break;
        case 80:
            print ("Tu es vieux maintenant !");
            break;
        default:
            print ("Rien à signaler");
            break;
        }
    }
}
