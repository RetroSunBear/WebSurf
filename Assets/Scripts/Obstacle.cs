using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Obstacle"))
        {
            gameManager.GameOver();
        }
    }

    private void OnMouseDown()
    {
        if(gameManager.isGameActive)
        {
            Destroy(gameObject);
            
        }
    }

}
