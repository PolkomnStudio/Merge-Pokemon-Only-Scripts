using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private AnimationEvent animationEvent;
    private float _speed = 0.005f;
    [SerializeField] private TextMesh _enemyHPText;
    [SerializeField] private int EnemyHP;
    private Rigidbody _rb;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        StartCoroutine(animationEvent.ChangeBlendParameterOverTime());
    }

    private void OnDisable()
    {
        StopCoroutine(animationEvent.ChangeBlendParameterOverTime());
    }
    void EnemyHPTextConv()
    {
        _enemyHPText.text = EnemyHP.ToString();
    }
    private void HitEvent()
    {
        //Debug.Log("HitEvent");
        if (EnemyHP != 0)
        {
            EnemyHP--;
            if (EnemyHP <= 0)
            {
                Disable();
            }

        }

    }
    
    private void Disable()
    {
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ammo"))
        {
            //Debug.Log("Ammo");
            HitEvent();
            //EnemyHPTextConv();
        }
        if (other.CompareTag("Finish"))
        {
            Disable();
        }
    }

    void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        _rb.AddForce(transform.forward * _speed, ForceMode.VelocityChange);
    }
    

}
