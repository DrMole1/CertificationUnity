using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxis : MonoBehaviour
{
	public float range;
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * range;
        float zPos = v * range;

        if (xPos!=0 || zPos!=0)
        {
        	transform.position = new Vector3(xPos,0,zPos);
        }
        
    }
}
