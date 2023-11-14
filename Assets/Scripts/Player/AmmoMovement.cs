using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoMovement : MonoBehaviour
{
    private float _speed = 0.1f;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        _rb.AddForce(transform.forward * -_speed, ForceMode.VelocityChange);
    }

    private void OnTriggerEnter(Collider other)
    {

        if ((other.CompareTag("Enemy")) || (other.CompareTag("Wall")))
        {
            //Debug.Log("Hit");
            Destroy(gameObject);
        }


    }
}
