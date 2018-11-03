using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text scoreText;
<<<<<<< HEAD
=======
<<<<<<< HEAD
    public Text healthText;
    public int playerHealth = 5;
=======
>>>>>>> 6fd58527ca60b3d8e376506fb461fecb2c2dd0f1
>>>>>>> parent of 515238d... Revert "Merge branch 'master' of https://github.com/DeathWish99/Zellin"

    private int score;

	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScore();
<<<<<<< HEAD
=======
<<<<<<< HEAD
        UpdateHealth();
=======
>>>>>>> 6fd58527ca60b3d8e376506fb461fecb2c2dd0f1
>>>>>>> parent of 515238d... Revert "Merge branch 'master' of https://github.com/DeathWish99/Zellin"
    }

    // Update is called once per frame
    public void AddScore(int newScoreValue) {
        score += newScoreValue;
        UpdateScore();
    }

<<<<<<< HEAD
    void UpdateScore () {
        scoreText.text = "Score: " + score;
	}
=======
<<<<<<< HEAD
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
=======
    void UpdateScore () {
        scoreText.text = "Score: " + score;
	}
>>>>>>> 6fd58527ca60b3d8e376506fb461fecb2c2dd0f1
>>>>>>> parent of 515238d... Revert "Merge branch 'master' of https://github.com/DeathWish99/Zellin"
}
