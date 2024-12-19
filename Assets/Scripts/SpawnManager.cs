using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos;

    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerMovement playerMovementScript;

    public float Xpos= 25;
    public float Ymin;
    public float Ymax;
    public float Zpos= 200;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerMovementScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    Vector3 RandomPos()
    {
        float Ypos = Random.Range(Ymin, Ymax);
        return new Vector3(Xpos, Ypos, Zpos);
    }
    void SpawnObstacle ()
   
    {
        if (playerMovementScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, RandomPos(), obstaclePrefab.transform.rotation);
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
