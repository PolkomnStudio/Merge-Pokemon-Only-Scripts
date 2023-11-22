using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UIInput : MonoBehaviour
{
    public static event Action PauseBtnActive;
    public static event Action AddPersonBtnActive;


    public void PauseBtnListener()
    {
        PauseBtnActive?.Invoke();
    }

    public void AddPersonBtnListener()
    {
        AddPersonBtnActive?.Invoke();
    }
}
