using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    private float spawnRangeX = 20;
    public float spawnPosZ = 20;

    // Start is called before the first frame update
    void Start()
    {
      

         
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
           
        }
    }

    void SpawnRandomEnemies()
    {
        int enemyIndex = Random.Range(0, enemyPrefab.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        
        Instantiate(enemyPrefab[enemyIndex], new Vector3(0, 0, 20) spawnpos, enemyPrefab[enemyIndex].transform.rotation);
    }
}
