using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject Delete;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))  //Pour détruire l'objet
        {
        	Destroy(gameObject);
        }
        else if(Input.GetKeyDown(KeyCode.X)) //Pour détruire un autre objet
        {
        	Destroy(Delete);
        }
        else if(Input.GetKeyDown(KeyCode.C))  //Pour détruire un component
        {
        	Destroy(GetComponent<Rigidbody>());
        }
    }
}
