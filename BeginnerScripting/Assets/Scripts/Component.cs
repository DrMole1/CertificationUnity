using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component : MonoBehaviour
{

	private Rigidbody Comp_Rigidbody; 
    // Start is called before the first frame update
    void Start()
    {
        Comp_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
        	Comp_Rigidbody.detectCollisions = false;
        }
    }
}
