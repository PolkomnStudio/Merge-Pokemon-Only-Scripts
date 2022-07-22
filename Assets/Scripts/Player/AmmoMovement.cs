using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    Rigidbody Rb;

    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Rb.AddForce(transform.forward * -speed, ForceMode.VelocityChange);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Enemy"))
        {
            //Debug.Log("Hit");
            Destroy(gameObject);
        }


    }
}
