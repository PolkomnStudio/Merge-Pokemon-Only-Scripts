using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GamePlay
{
    public class PlayerBulletBank : MonoBehaviour
    {
        public static event Action<int> BulletsValue;
        public int BulletCount { private set; get; } = 0;

        private void OnEnable()
        {
            Enemy.EnemyHPValue += BulletCountAdd;
            InputUI.FireBtnActive += BulletCountSub;
        }
        private void OnDisable()
        {
            Enemy.EnemyHPValue -= BulletCountAdd;
            InputUI.FireBtnActive -= BulletCountSub;
        }

        private void BulletCountAdd(int newBulletCount)
        {
            BulletCount += newBulletCount;
            BulletsValue?.Invoke(BulletCount);
        }

        private void BulletCountSub()
        {
            if (BulletCount > 0)
            {
                BulletCount--;
                BulletsValue?.Invoke(BulletCount);
            }
            
        }
    }
}

