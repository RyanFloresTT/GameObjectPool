using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody rb;
    private GameObjectPool pool;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Fire()
    {
        rb.velocity = transform.forward * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
