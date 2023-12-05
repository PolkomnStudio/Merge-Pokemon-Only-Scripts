using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    [SerializeField] private RespawnEnemy _respawnEnemyScript;

    [SerializeField] private Transform[] respPoints;
    private float _periodEnemySpawn = 10f;

    private void Start()
    {
        StartCoroutine(EnemyRespawn(_periodEnemySpawn));
    }

    private IEnumerator EnemyRespawn(float PeriodSpawn)
    {
        _respawnEnemyScript.Respawn(respPoints[0], respPoints[1], respPoints[2], respPoints[3], "Low");
        while (true)
        {
            yield return new WaitForSeconds(PeriodSpawn);
            _respawnEnemyScript.Respawn(respPoints[0], respPoints[1], respPoints[2], respPoints[3], "Low");
        }
        //while (_uiView._totalKillCount >= 5)
        //{
        //    yield return new WaitForSeconds(PeriodSpawn);
        //    _respawnEnemyScript.Respawn(respPoints[0], respPoints[1], respPoints[2], respPoints[3], respPoints[4], "Hard");
        //}
    }
}
