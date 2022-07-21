using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private TextMesh text;
    private int HP;
    Rigidbody Rb;
    
    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Rb.AddForce(transform.forward * -speed, ForceMode.Force);
    }
}
