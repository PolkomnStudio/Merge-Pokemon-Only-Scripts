﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLineRespawn : MonoBehaviour
{
    [SerializeField] private SceneController sceneController;
    private bool TriggerEvent = false;

    private void OnTriggerEnter(Collider other)
    {
        
        if ((other.CompareTag("Enemy")) && (!TriggerEvent))
        {
            sceneController.RespawnEnemy(); //Нужно, чтобы выполнялось только один раз, а т.к обнаруживаются несколько GO вызывается метод несколько раз!
            TriggerEvent = true;
            Invoke("ChangeTriggerEvent", 3f);
        }

    }

    private void ChangeTriggerEvent()
    {
        TriggerEvent = false;
    }
}