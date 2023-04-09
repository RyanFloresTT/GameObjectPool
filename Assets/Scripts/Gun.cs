using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform[] firePoint;
    [SerializeField] private GameObjectPool bulletPool = new();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        var firedBullet = bulletPool.Get();
        firedBullet.transform.position = firePoint[0].position;
        firedBullet.GetComponent<Bullet>().Fire();
    }
}
b