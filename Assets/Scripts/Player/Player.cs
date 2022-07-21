using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float XRange;
    [SerializeField] private float LMaxRange;
    [SerializeField] private float RMaxRange;
    [SerializeField] private Transform GunPoint;
    [SerializeField] private GameObject AmmoPrefab;


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void LeftMove()
    {
        if (gameObject.transform.position.x != LMaxRange)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - XRange, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        
    }
    public void RightMove()
    {
        if (gameObject.transform.position.x != RMaxRange)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + XRange, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }

   
    public void Attack()
    {
        Instantiate(AmmoPrefab, GunPoint.position, GunPoint.rotation);
    }
}
