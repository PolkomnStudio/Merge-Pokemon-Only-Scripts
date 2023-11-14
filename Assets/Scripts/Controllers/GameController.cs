using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

namespace GamePlay
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private RespawnEnemy _respawnEnemyScript;
        [SerializeField] private UIView _uiView;

        [SerializeField] private Transform[] respPoints;
        private float _periodEnemySpawn = 7f;

        private void Start()
        {
            StartCoroutine(EnemyRespawn(_periodEnemySpawn));
        }

        private IEnumerator EnemyRespawn(float PeriodSpawn)
        {
            _respawnEnemyScript.Respawn(respPoints[0], respPoints[1], respPoints[2], respPoints[3], respPoints[4], "Low");
            while (_uiView._totalKillCount < 5)
            {
                yield return new WaitForSeconds(PeriodSpawn);
                _respawnEnemyScript.Respawn(respPoints[0], respPoints[1], respPoints[2], respPoints[3], respPoints[4], "Low");

            }
            while (_uiView._totalKillCount >= 5)
            {
                yield return new WaitForSeconds(PeriodSpawn);
                _respawnEnemyScript.Respawn(respPoints[0], respPoints[1], respPoints[2], respPoints[3], respPoints[4], "Hard");
            }

        }


        public void LoadScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }



    }
}

