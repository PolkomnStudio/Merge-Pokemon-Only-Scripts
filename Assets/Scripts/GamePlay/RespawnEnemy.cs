using UnityEngine;

public class RespawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefab;
    private int NumEnemy;

    public void Respawn(Transform respPoint0, Transform respPoint1, Transform respPoint2, Transform respPoint3, Transform respPoint4, string level)
    {
        switch (level)
        {
            case "Low":
                NumEnemy = Random.Range(1, 8);
                break;
            case "Hard":
                NumEnemy = Random.Range(8, 14);
                break;
        }
        
        switch (NumEnemy)
        {
            case 1:
                {
                    Instantiate(EnemyPrefab, respPoint0.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint3.position, EnemyPrefab.transform.rotation);
                }
                break;
            case 2:
                {
                    Instantiate(EnemyPrefab, respPoint0.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint4.position, EnemyPrefab.transform.rotation);
                }
                break;
            case 3:
                {
                    Instantiate(EnemyPrefab, respPoint1.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint2.position, EnemyPrefab.transform.rotation);
                }
                break;
            case 4:
                {
                    Instantiate(EnemyPrefab, respPoint2.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint3.position, EnemyPrefab.transform.rotation);
                }
                break;
            case 5:
                {
                    Instantiate(EnemyPrefab, respPoint1.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint3.position, EnemyPrefab.transform.rotation);
                }
                break;
            case 6:
                {
                    Instantiate(EnemyPrefab, respPoint1.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint4.position, EnemyPrefab.transform.rotation);
                }
                break;
            case 7:
                {
                    Instantiate(EnemyPrefab, respPoint2.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint4.position, EnemyPrefab.transform.rotation);
                }
                break;
            case 8:
                {
                    Instantiate(EnemyPrefab, respPoint0.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint2.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint4.position, EnemyPrefab.transform.rotation);
                }
                break;
            case 9:
                {
                    Instantiate(EnemyPrefab, respPoint0.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint1.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint4.position, EnemyPrefab.transform.rotation);
                }
                break;
            case 10:
                {
                    Instantiate(EnemyPrefab, respPoint0.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint3.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint4.position, EnemyPrefab.transform.rotation);
                }
                break;
            case 11:
                {
                    Instantiate(EnemyPrefab, respPoint0.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint2.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint3.position, EnemyPrefab.transform.rotation);
                }
                break;
            case 12:
                {
                    Instantiate(EnemyPrefab, respPoint0.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint1.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint2.position, EnemyPrefab.transform.rotation);
                }
                break;
            case 13:
                {
                    Instantiate(EnemyPrefab, respPoint0.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint1.position, EnemyPrefab.transform.rotation);
                    Instantiate(EnemyPrefab, respPoint3.position, EnemyPrefab.transform.rotation);
                }
                break;
        }

    }
}
