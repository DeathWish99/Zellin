using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text scoreText;

    private int score;

	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScore();
    }

    // Update is called once per frame
    public void AddScore(int newScoreValue) {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore () {
        scoreText.text = "Score: " + score;
	}
}
