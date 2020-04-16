using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrapping : MonoBehaviour
{
    void Update()
    {
        //Pour autoriser la box ENABLED dans l'interface
    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CheckBounds(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Bullet"))
        {
            CheckBounds(other.gameObject);
        }
    }

    void CheckBounds(GameObject obj)
    {
        Vector2 sizeBackground = GameObject.Find("Background").GetComponent<SpriteRenderer>().size;

        if(obj.transform.position.x > sizeBackground.x)
        {
            obj.transform.position = new Vector3(-sizeBackground.x, obj.transform.position.y, obj.transform.position.z);
        }
        if (obj.transform.position.x < sizeBackground.x * -1)
        {
            obj.transform.position = new Vector3(obj.transform.position.x * -1, obj.transform.position.y, obj.transform.position.z);
        }
        if (obj.transform.position.y > sizeBackground.y)
        {
            obj.transform.position = new Vector3(obj.transform.position.x, -sizeBackground.y, obj.transform.position.z);
        }
        if (obj.transform.position.y < sizeBackground.y * -1)
        {
            obj.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y * -1, obj.transform.position.z);
        }
    }
}
