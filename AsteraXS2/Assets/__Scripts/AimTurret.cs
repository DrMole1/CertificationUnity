using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTurret : MonoBehaviour
{
    public Camera cam;
    Vector3 targetPosition;

    // Gestion de la visée du canon
    void Update()
    {
        if(Input.mousePresent)
        {
            targetPosition = cam.ScreenToWorldPoint(Input.mousePosition + Vector3.back * cam.transform.position.z);
            transform.LookAt(targetPosition, Vector3.back); 
        }
    }

    public Vector3 GetTargetPosition()
    {
        return targetPosition;
    }
}

// NO fonctionnal
/*Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
Vector3 lookDir = new Vector3(mousePos.x, mousePos.y, 0) - transform.position;
transform.rotation = Quaternion.LookRotation(lookDir);*/
