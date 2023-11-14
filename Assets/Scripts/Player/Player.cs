using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GamePlay
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerBulletBank playerBulletBank;

        [SerializeField] private float XRange;
        [SerializeField] private float LMaxRange;
        [SerializeField] private float RMaxRange;
        [SerializeField] private Transform GunPoint;
        [SerializeField] private GameObject AmmoPrefab;

        


        private void OnEnable()
        {
            InputUI.MoveLeftBtnActive += LeftMove;
            InputUI.MoveRightBtnActive += RightMove;
            InputUI.FireBtnActive += Attack;
        }

        private void OnDisable()
        {
            InputUI.MoveLeftBtnActive -= LeftMove;
            InputUI.MoveRightBtnActive -= RightMove;
            InputUI.FireBtnActive -= Attack;
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
            if (playerBulletBank.BulletCount > 0)
            {
                Instantiate(AmmoPrefab, GunPoint.position, GunPoint.rotation);
            }
             
        }
    }

}
