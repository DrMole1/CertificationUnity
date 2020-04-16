using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCBehaviour : MonoBehaviour
{

    ScriptableAsteroidC scriptableAsteroidC;

    void Start()
    {
        Initialisation();

    }


    void Update()
    {
        Movement();
        
    }


    /// <summary>
    /// Méthode servant à initialiser le visuel de l'asteroid selon le scriptable associé, aidant le graphiste pour insérer ses fichiers.
    /// </summary>
    void Initialisation()
    {

        this.GetComponent<MeshFilter>().mesh = scriptableAsteroidC.meshAsteroidC;
        this.GetComponent<Renderer>().material = scriptableAsteroidC.matAsteroidC;
        this.transform.localScale = new Vector3(scriptableAsteroidC.size, scriptableAsteroidC.size, scriptableAsteroidC.size);

        this.transform.rotation = Random.rotation;
    }


    void Movement()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 3);
        transform.Translate(Vector3.up * Time.deltaTime * 5);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Explode();
        }
        else if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            Explode();
        }
    }

    void Explode()
    {

        Destroy(gameObject);
    }
}
