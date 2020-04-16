using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float resultat = Mathf.Lerp(1f,5f,0.5f);
        print("Le resultat de l'interpolation est : " + resultat);

        Vector3 Depuis = new Vector3(3f,5f,2f);
        Vector3 Jusque = new Vector3(1f,4f,7f);

        Vector3 result = Vector3.Lerp(Depuis,Jusque,0.5f);
        print("Le nouveau vector est de : " + result);
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Light>().intensity = Mathf.Lerp(GetComponent<Light>().intensity, 8f, 0.5f*Time.deltaTime);
    }
}
