using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;


namespace GamePlay
{
    public class ScanerController : MonoBehaviour
    {
        public static event Action<int> CDTimerValue;

        private float CDValue = 4f;
        private float VTValue = 2f;

        public static event Action EnemyVisible;
        public static event Action EnemyInvisible;

        private float CDValueCurrent;
        private float VTValueCurrent;

        private bool isCoolDownGoing;
        private bool isVisibleTimerGoing;


        private void OnEnable()
        {
            InputUI.ScanerBtnActive += StartVisibleTimer;
        }

        private void OnDisable()
        {
            InputUI.ScanerBtnActive -= StartVisibleTimer;
        }

        private IEnumerator VisibleTimer()
        {
            while (isVisibleTimerGoing)
            {
                VTValueCurrent -= Time.deltaTime;

                if (VTValueCurrent <= 0f)
                {
                    EndVisibleTimer();
                }

                yield return null;
            }
        }
        
        private void StartVisibleTimer()
        {
            if (!isCoolDownGoing)
            {
                VTValueCurrent = VTValue;
                isVisibleTimerGoing = true;
                StartCoroutine(VisibleTimer());
                EnemyVisible?.Invoke();
            }

        }
        private void EndVisibleTimer()
        {
            isVisibleTimerGoing = false;
            StopCoroutine(VisibleTimer());
            EnemyInvisible?.Invoke();
            StartCDTimer();
        }

        private IEnumerator CoolDownTimer()
        {
            while (isCoolDownGoing)
            {
                CDValueCurrent -= Time.deltaTime;
                if (CDValueCurrent > 0f) CDTimerValue?.Invoke((int)CDValueCurrent);
                else CDTimerValue?.Invoke(0);
                if (CDValueCurrent <= 0f)
                {
                    EndCDTimer();
                }

                yield return null;
            }
        }

        private void StartCDTimer()
        {
            CDValueCurrent = CDValue;
            isCoolDownGoing = true;
            StartCoroutine(CoolDownTimer());
            
            
        }
        private void EndCDTimer()
        {
            isCoolDownGoing = false;
            StopCoroutine(CoolDownTimer());
            
        }

        

    }
}

