using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float speed = 10.0f;

    // Gestion des mouvements du vaisseau selon les Axis
    void Update()
    {
        float h = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        float v = speed * Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(h, v, 0);
    }
}
