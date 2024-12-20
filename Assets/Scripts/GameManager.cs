using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI gameOverText;
    public bool isGameActive;

    private float spawnRate = 1.0f;
    public List<GameObject> targets;

    public Button restartButton;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        score = 0;

        UpdateScore(0);

    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score" + score;
    }

    IEnumerator SpawnTarget()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void Restartgame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
