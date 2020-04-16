using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject bullet;
    AimTurret aimturret;

    void Start()
    {
        aimturret = GameObject.Find("TurretRotator").GetComponent<AimTurret>();
    }

    // Tirer des projectiles
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject instanceBullet;
            instanceBullet = Instantiate(bullet, transform.position, transform.rotation);

            instanceBullet.transform.SetParent(GameObject.Find("BulletAnchor").transform);

            instanceBullet.GetComponent<Rigidbody>().AddForce(aimturret.GetTargetPosition() * 100.0f);

            StartCoroutine(DestroyBullet(instanceBullet));
        }
    }

    IEnumerator DestroyBullet(GameObject instanceBullet)
    {
        yield return new WaitForSeconds(2f);

        Destroy(instanceBullet);
    }
}
