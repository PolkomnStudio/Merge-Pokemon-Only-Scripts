using System;
using UnityEngine;
using UnityEngine.UI;
using GamePlay;

public class Enemy : MonoBehaviour
{
    private float _speed = 0.01f;
    [SerializeField] private TextMesh _enemyHPText;
    private int EnemyHP;
    private Rigidbody _rb;

    public static event Action EnemyDisable;
    public static event Action<int> EnemyHPValue;
    public static event Action EnemyFinish;


    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        

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

    private void Visible()
    {
        var material = GetComponent<Renderer>().material;
        var color = material.color;
        color.a = 1f;
        material.color = color;

        var material1 = GetComponentInChildren<TextMesh>();
        var color1 = material1.color;
        color1.a = 1f;
        material1.color = color1;

        var EnemyHPtext = GetComponentInChildren<TextMesh>();
        _enemyHPText.text = EnemyHPtext.text;
        
    }

    private void Invisible()
    {
        var material = GetComponent<Renderer>().material;
        var color = material.color;
        color.a = 0f;
        material.color = color;

        var material1 = GetComponentInChildren<TextMesh>();
        var color1 = material1.color;
        color1.a = 0f;
        material1.color = color1;

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
            EnemyHPTextConv();
        }
        if (other.CompareTag("Finish"))
        {
            EnemyFinish?.Invoke();
            Disable();
        }
    }
    
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _rb.AddForce(transform.forward * -_speed, ForceMode.VelocityChange);
    }

    private void OnEnable()
    {
        EnemyHP = UnityEngine.Random.Range(1, 4);
        EnemyHPValue?.Invoke(EnemyHP);
        EnemyHPTextConv();

        ScanerController.EnemyVisible += Visible;
        ScanerController.EnemyInvisible += Invisible;
    }

    private void OnDisable()
    {
        ScanerController.EnemyVisible -= Visible;
        ScanerController.EnemyInvisible -= Invisible;
        EnemyDisable?.Invoke();
    }
}
