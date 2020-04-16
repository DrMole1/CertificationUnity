using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    void OnMouseDown()
    {
    	GetComponent<Rigidbody>().AddForce(-transform.forward * 500.0f);
    	GetComponent<Rigidbody>().useGravity = true;
    }
}


	