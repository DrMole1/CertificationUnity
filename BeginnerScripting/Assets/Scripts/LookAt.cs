using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform Cible;
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Cible); //pour que la caméra suive la cible
    }
}
