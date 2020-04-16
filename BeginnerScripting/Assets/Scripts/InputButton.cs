using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputButton : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
    	bool down = Input.GetKeyDown(KeyCode.M);
    	bool held = Input.GetKey(KeyCode.M);
    	bool up = Input.GetKeyUp(KeyCode.M);

        if(down)
        {
        	GetComponent<Renderer>().material.color = Color.green;
        }
        if(held)
        {
        	GetComponent<Renderer>().material.color = Color.blue;
        }
        if(up)
        {
        	GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
