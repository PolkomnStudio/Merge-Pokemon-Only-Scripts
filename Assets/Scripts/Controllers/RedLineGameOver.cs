using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLineGameOver : MonoBehaviour
{
    [SerializeField] private SceneController sceneController;
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Enemy"))
        {
            sceneController.GameOver();
            
        }

    }
}
