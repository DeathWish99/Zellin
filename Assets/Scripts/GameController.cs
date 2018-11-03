using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text scoreText;
    public Text healthText;
    public int playerHealth = 5;

    private int score;

	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScore();
        UpdateHealth();
    }
    
    public void AddScore(int newScoreValue) {
        score += newScoreValue;
        UpdateScore();
    }
    public void TakeDamage(int damageValue)
    {
        playerHealth -= damageValue;
        UpdateHealth();
    }

    void UpdateScore () {
        scoreText.text = "Score: " + score;
	}

    void UpdateHealth ()
    {
        healthText.text = "Health: " + playerHealth;
    }
