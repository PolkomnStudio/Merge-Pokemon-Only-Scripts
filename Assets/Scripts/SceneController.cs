using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefab;
    public GameObject[] enemy;
    [SerializeField] private Transform[] respPoints;
    

    private void Awake()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        //UnVisibleObjects();
    }
    void Start()
    {
        RespawnEnemy();
    }

    public void ClickScaner()
    {
        StartCoroutine(VisibleObjects());
    }
    IEnumerator VisibleObjects()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject respawn in enemy)
        {
            respawn.SetActive(true);
        }
        //Invoke("UnVisibleObjects", 3f);
        yield return new WaitForSeconds(3f);
    }

    public void UnVisibleObjects()
    {
        foreach (GameObject respawn in enemy)
        {
            respawn.SetActive(false);
        }
        
    }

    
    private void RespawnEnemy()
    {
        int NumEnemy = Random.Range(1, 11);
        Debug.Log(NumEnemy);
        switch (NumEnemy)
        {
            case 1:
                {
                    Instantiate(EnemyPrefab, respPoints[1].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoints[3].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 2:
                {
                    Instantiate(EnemyPrefab, respPoints[0].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoints[2].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoints[4].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 3:
                {
                    Instantiate(EnemyPrefab, respPoints[0].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoints[1].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoints[4].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 4:
                {
                    Instantiate(EnemyPrefab, respPoints[0].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoints[3].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoints[4].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 5:
                {
                    Instantiate(EnemyPrefab, respPoints[0].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoints[4].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 6:
                {
                    Instantiate(EnemyPrefab, respPoints[1].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoints[2].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 7:
                {
                    Instantiate(EnemyPrefab, respPoints[2].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoints[3].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 8:
                {
                    Instantiate(EnemyPrefab, respPoints[0].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoints[3].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 9:
                {
                    Instantiate(EnemyPrefab, respPoints[1].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoints[4].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 10:
                {
                    Instantiate(EnemyPrefab, respPoints[2].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoints[4].position, EnemyPrefab.transform.rotation);
                }
                break;
        }
         
    }

    void Update()
    {
        //Instantiate(respawnPrefab, respPoints[Random.Range(0, respPoints.Length)].position, respawn.transform.rotation);
    }
}
