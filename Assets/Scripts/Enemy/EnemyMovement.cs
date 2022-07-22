using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private TextMesh text;
    //private int EnemyHP;
    Rigidbody Rb;

    public int EnemyHP { get; private set; }

    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
        EnemyHP = Random.Range(1, 4);
        EnemyHPTextConv();
    }

    void EnemyHPTextConv()
    {
        text.text = EnemyHP.ToString();
    }

    void HitEvent()
    {
        //Debug.Log("HitEvent");
        if (EnemyHP != 0)
        {
            EnemyHP--;
            if (EnemyHP == 0) EnemyDestroy();
        }
        else EnemyDestroy();



    }

    void EnemyDestroy()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ammo"))
        {
            Debug.Log("Ammo");
            HitEvent();
            //EnemyHPTextConv();
        }
    }
    void FixedUpdate()
    {
        Rb.AddForce(transform.forward * -speed, ForceMode.Force);
    }
}
