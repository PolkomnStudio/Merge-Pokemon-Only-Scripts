using System;
using UnityEngine;

namespace GamePlay
{
    public class InputUI : MonoBehaviour
    {
        public static event Action ScanerBtnActive;
        public static event Action MoveLeftBtnActive;
        public static event Action MoveRightBtnActive;
        public static event Action FireBtnActive;
        public static event Action SettingBtnActive;
        public static event Action SettingExitBtnActive;


        public void ScanerBtnListener()
        {
            ScanerBtnActive?.Invoke();
        }

        public void MoveLeftBtnListener()
        {
            MoveLeftBtnActive?.Invoke();
        }

        public void MoveRightBtnListener()
        {
            MoveRightBtnActive?.Invoke();
        }

        public void FireBtnListener()
        {
            FireBtnActive?.Invoke();
        }

        public void SettingBtnListener()
        {
            SettingBtnActive?.Invoke();
        }

        public void SettingExitBtnListener()
        {
            SettingExitBtnActive?.Invoke();
        }
    }
}

