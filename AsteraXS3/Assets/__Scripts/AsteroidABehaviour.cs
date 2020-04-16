using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidABehaviour : MonoBehaviour
{

    ScriptableAsteroidA scriptableAsteroidA;
    public GameObject prefabNextAsteroid;

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

        this.GetComponent<MeshFilter>().mesh = scriptableAsteroidA.meshAsteroidA;
        this.GetComponent<Renderer>().material = scriptableAsteroidA.matAsteroidA;
        this.transform.localScale = new Vector3(scriptableAsteroidA.size, scriptableAsteroidA.size, scriptableAsteroidA.size);

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
        GameObject instanceAsteroidB1;
        instanceAsteroidB1 = Instantiate(prefabNextAsteroid, transform.position, Quaternion.identity);
        GameObject instanceAsteroidB2;
        instanceAsteroidB2 = Instantiate(prefabNextAsteroid, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
