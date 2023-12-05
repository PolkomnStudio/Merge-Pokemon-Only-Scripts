using UnityEngine;
public class RespawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefabLvl1;
    [SerializeField] private GameObject EnemyPrefabLvl2;
    [SerializeField] private GameObject EnemyPrefabLvl3;
    private int NumEnemy;
    public void Respawn(Transform respPoint0, Transform respPoint1, Transform respPoint2, Transform respPoint3, string level)
    {
        switch (level)
        {
            case "Low":
                NumEnemy = Random.Range(1, 7);
                break;
            case "Hard":
                NumEnemy = Random.Range(5, 9);
                break;
        }

        switch (NumEnemy)
        {
            case 1:
                {
                    Instantiate(EnemyPrefabLvl1, respPoint0.position, EnemyPrefabLvl1.transform.rotation);
                    Instantiate(EnemyPrefabLvl1, respPoint3.position, EnemyPrefabLvl1.transform.rotation);
                }
                break;
            case 2:
                {
                    Instantiate(EnemyPrefabLvl1, respPoint0.position, EnemyPrefabLvl1.transform.rotation);
                    Instantiate(EnemyPrefabLvl1, respPoint2.position, EnemyPrefabLvl1.transform.rotation);
                }
                break;
            case 3:
                {
                    Instantiate(EnemyPrefabLvl1, respPoint1.position, EnemyPrefabLvl1.transform.rotation);
                    Instantiate(EnemyPrefabLvl1, respPoint2.position, EnemyPrefabLvl1.transform.rotation);
                }
                break;
            case 4:
                {
                    Instantiate(EnemyPrefabLvl1, respPoint2.position, EnemyPrefabLvl1.transform.rotation);
                    Instantiate(EnemyPrefabLvl1, respPoint3.position, EnemyPrefabLvl1.transform.rotation);
                }
                break;
            case 5:
                {
                    Instantiate(EnemyPrefabLvl1, respPoint1.position, EnemyPrefabLvl1.transform.rotation);
                    Instantiate(EnemyPrefabLvl1, respPoint3.position, EnemyPrefabLvl1.transform.rotation);
                }
                break;
            case 6:
                {
                    Instantiate(EnemyPrefabLvl1, respPoint0.position, EnemyPrefabLvl1.transform.rotation);
                    Instantiate(EnemyPrefabLvl1, respPoint1.position, EnemyPrefabLvl1.transform.rotation);
                }
                break;
            case 7:
                {
                    Instantiate(EnemyPrefabLvl1, respPoint0.position, EnemyPrefabLvl1.transform.rotation);
                    Instantiate(EnemyPrefabLvl1, respPoint2.position, EnemyPrefabLvl1.transform.rotation);
                    Instantiate(EnemyPrefabLvl2, respPoint3.position, EnemyPrefabLvl2.transform.rotation);
                }
                break;
            case 8:
                {
                    Instantiate(EnemyPrefabLvl2, respPoint0.position, EnemyPrefabLvl2.transform.rotation);
                    Instantiate(EnemyPrefabLvl1, respPoint1.position, EnemyPrefabLvl1.transform.rotation);
                    Instantiate(EnemyPrefabLvl2, respPoint3.position, EnemyPrefabLvl2.transform.rotation);
                }
                break;
            //case 10:
            //    {
            //        Instantiate(EnemyPrefab, respPoint0.position, EnemyPrefab.transform.rotation);
            //        Instantiate(EnemyPrefab, respPoint3.position, EnemyPrefab.transform.rotation);
            //        Instantiate(EnemyPrefab, respPoint4.position, EnemyPrefab.transform.rotation);
            //    }
            //    break;
            //case 11:
            //    {
            //        Instantiate(EnemyPrefab, respPoint0.position, EnemyPrefab.transform.rotation);
            //        Instantiate(EnemyPrefab, respPoint2.position, EnemyPrefab.transform.rotation);
            //        Instantiate(EnemyPrefab, respPoint3.position, EnemyPrefab.transform.rotation);
            //    }
            //    break;
            //case 12:
            //    {
            //        Instantiate(EnemyPrefab, respPoint0.position, EnemyPrefab.transform.rotation);
            //        Instantiate(EnemyPrefab, respPoint1.position, EnemyPrefab.transform.rotation);
            //        Instantiate(EnemyPrefab, respPoint2.position, EnemyPrefab.transform.rotation);
            //    }
            //    break;
            //case 13:
            //    {
            //        Instantiate(EnemyPrefab, respPoint0.position, EnemyPrefab.transform.rotation);
            //        Instantiate(EnemyPrefab, respPoint1.position, EnemyPrefab.transform.rotation);
            //        Instantiate(EnemyPrefab, respPoint3.position, EnemyPrefab.transform.rotation);
            //    }
            //    break;
        }
    }
}