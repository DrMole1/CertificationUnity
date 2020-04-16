using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public Rigidbody CubePrefab;
    public Transform AuSol;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Equals))
        {
        	Rigidbody CubeInstance;
        	CubeInstance = Instantiate(CubePrefab, AuSol.position, AuSol.rotation) as Rigidbody;
        	CubeInstance.AddForce(AuSol.forward * 500);
        }
    }
}
