using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefab;
    public GameObject[] enemy;
    [SerializeField] private Transform[] respPoints;
    [SerializeField] private Transform[] EnemyPoint_1Wave;
    [SerializeField] private Transform[] EnemyPoint_2Wave;
    [SerializeField] private GameObject GameOverPanel;

    private void Awake()
    {
        StartRespawnEnemy1Wave();
        StartRespawnEnemy2Wave();
        RespawnEnemy();
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        
    }
    void Start()
    {
        
    }


    public void ClickScaner()
    {
        StartCoroutine(VisibleObjects());
    }
    public void UnvisibleCorotine()
    {
        StartCoroutine(UnVisibleObjects());
    }

    IEnumerator VisibleObjects()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject respawn in enemy)
        {
            //for (float ft = 0f; ft <= 1; ft += 0.25f)
            //{
            var material = respawn.GetComponent<Renderer>().material;
            var color = material.color;
            color.a = 1f;
            material.color = color;

            var material1 = respawn.GetComponentInChildren<TextMesh>();
            var color1 = material1.color;
            color1.a = 1f;
            material1.color = color1;

            //}

        }
        yield return null;
        Invoke("UnvisibleCorotine", 3f);

    }

    IEnumerator UnVisibleObjects()
    {

        foreach (GameObject respawn in enemy)
        {
            //for (float ft = 1f; ft >= 0; ft -= 0.25f)
            //{
            var material = respawn.GetComponent<Renderer>().material;
            var color = material.color;
            color.a = 0f;
            material.color = color;

            var material1 = respawn.GetComponentInChildren<TextMesh>();
            var color1 = material1.color;
            color1.a = 0f;
            material1.color = color1;

            // }
        }
        yield return null;

    }

    public void GameOver()
    {
        Time.timeScale = 0f;

        GameOverPanel.SetActive(true);
    }

    public void RestartScene()
    {
        
        GameOverPanel.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void StartRespawnEnemy1Wave()
    {
        int NumEnemy = Random.Range(1, 11);
        //Debug.Log(NumEnemy);
        switch (NumEnemy)
        {
            case 1:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[1].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[3].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 2:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[0].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[2].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[4].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 3:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[0].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[1].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[4].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 4:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[0].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[3].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[4].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 5:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[0].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[4].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 6:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[1].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[2].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 7:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[2].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[3].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 8:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[0].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[3].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 9:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[1].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[4].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 10:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[2].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_1Wave[4].position, EnemyPrefab.transform.rotation);
                }
                break;
        }
    }

    private void StartRespawnEnemy2Wave()
    {
        int NumEnemy = Random.Range(1, 11);
       // Debug.Log(NumEnemy);
        switch (NumEnemy)
        {
            case 1:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[1].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[3].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 2:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[0].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[2].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[4].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 3:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[0].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[1].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[4].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 4:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[0].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[3].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[4].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 5:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[0].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[4].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 6:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[1].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[2].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 7:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[2].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[3].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 8:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[0].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[3].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 9:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[1].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[4].position, EnemyPrefab.transform.rotation);
                }
                break;
            case 10:
                {
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[2].position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, EnemyPoint_2Wave[4].position, EnemyPrefab.transform.rotation);
                }
                break;
        }
    }

    public void RespawnEnemy()
    {
        int NumEnemy = Random.Range(1, 11);
        //Debug.Log(NumEnemy);
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


} 
