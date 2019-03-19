﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{

    public GameObject hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

   public Text PlainScore;
    public Text restartText;
    public Text gameOverText;
   private int score = 0;

    private bool gameOver;
    private bool restart;

    void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";

        GameObject TextScore = GameObject.FindWithTag("TextScore");
        if (TextScore != null)
        {
            PlainScore = TextScore.GetComponent<Text>();
        }
       score = 0;
       UpdateScore();
        StartCoroutine(SpawnWaves());
    }

    private void Update()
    {
        if (restart)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }

            yield return new WaitForSeconds(waveWait);
            if (gameOver)
            {
                restartText.text = "Press R for restart this level";
                restart = true;
                break;
            }

        }

    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        PlainScore.text = "Score:" + score; // изволило не заработать, указанный тип переменной "Text" не существует
    }

    public void GameOver()
    {
        gameOverText.text = "Game Over";
        Player.hitPoints = 3;
        gameOver = true;
    }

}