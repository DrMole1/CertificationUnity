using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateRotate : MonoBehaviour
{
	public float vitesse = 7.0f;
	public float tourner = 14.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
        	transform.Translate(Vector3.forward * vitesse * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
        	transform.Translate(-Vector3.forward * vitesse * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
        	transform.Rotate(Vector3.up, tourner * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
        	transform.Rotate(Vector3.up, -tourner * Time.deltaTime);
        }
    }
}
