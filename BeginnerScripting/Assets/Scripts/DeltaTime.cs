using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTime : MonoBehaviour
{
    public float vitesse = 7.0f;
    public float cooldown = 5.0f;

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (cooldown >= -1 && cooldown <= 0)
        {
        	print("C'est l'heure du del-del-del-delta Time !");
        }

        if(Input.GetKey(KeyCode.E))
        {
        	transform.position += new Vector3(vitesse * Time.deltaTime, 0.5f, 0.5f); //Pour le faire déplacer de façon smooth
        }
    }
}
