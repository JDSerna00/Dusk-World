using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject platform2Prefab;
    public GameObject platform3Prefab;
    public GameObject platform4Prefab;
    public GameObject monedasPrefab;
    public GameObject enemigo1Prefab;
    public GameObject enemigo2Prefab;

    public int platformCount = 200;
    public int platform2Count = 30;
    public int platform3Count = 20;
    public int platform4Count = 10;
    public int monedasCount = 500;
    public int enemigo1Count = 20;
    public int enemigo2Count = 15;

    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < platformCount; i++)
        {
            spawnPosition.y += Random.Range(100f, 100f);
            spawnPosition.x = Random.Range(-20f, 20f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }

        Vector3 spawnPosition2 = new Vector3();

        for (int i = 0; i < platform2Count; i++)
        {
            spawnPosition2.y += Random.Range(130f, 130f);
            spawnPosition2.x = Random.Range(-20f, 20f);
            Instantiate(platform2Prefab, spawnPosition2, Quaternion.identity);
        }

        Vector3 spawnPosition3 = new Vector3();

        for (int i = 0; i < platform3Count; i++)
        {
            spawnPosition3.y += Random.Range(150f, 150f);
            spawnPosition3.x = Random.Range(-25f, 25f);
            Instantiate(platform3Prefab, spawnPosition3, Quaternion.identity);
        }

        Vector3 spawnPosition4 = new Vector3();

        for (int i = 0; i < platform4Count; i++)
        {
            spawnPosition4.y += Random.Range(170f, 170f);
            spawnPosition4.x = Random.Range(-23f, 23f);
            Instantiate(platform4Prefab, spawnPosition4, Quaternion.identity);
        }

        Vector3 spawnPositionEnemigo1 = new Vector3();

        for (int i = 0; i < enemigo1Count; i++)
        {
            spawnPositionEnemigo1.y += Random.Range(120f, 120f);
            spawnPositionEnemigo1.x = Random.Range(-10f, 10f);
            Instantiate(enemigo1Prefab, spawnPositionEnemigo1, Quaternion.identity);
        }

        Vector3 spawnPositionEnemigo2 = new Vector3();

        for (int i = 0; i < enemigo2Count; i++)
        {
            spawnPositionEnemigo2.y += Random.Range(150f, 150f);
            spawnPositionEnemigo2.x = Random.Range(-13f, 13f);
            Instantiate(enemigo2Prefab, spawnPositionEnemigo2, Quaternion.identity);
        }


        Vector3 spawnMonedasPosition = new Vector3();

        for (int i = 0; i < monedasCount; i++)
        {
            spawnMonedasPosition.y += Random.Range(40f, 40f);
            spawnMonedasPosition.x = Random.Range(-15f, 15f);
            Instantiate(monedasPrefab, spawnMonedasPosition, Quaternion.identity);
        }
    }
}
