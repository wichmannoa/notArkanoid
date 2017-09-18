using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour {
    //Keeps track of the score;
    public Ball ballScript;

    private int score;
    private int highScore;
    private int destroyedBricks;

    public int Score
    {
        get
        {
            return score;
        }
    }
    public int HighScore {
        get {
            return highScore;
        }
    }

    void Start () {
        score = 0;
        highScore = PlayerPrefs.GetInt("highScore", 0);
    }
	
	void Update () {
        if (!ballScript)
        {
            //do nothing
        }
        else {
           destroyedBricks = ballScript.GetComponent<Ball>().GetDestroyedBricks();
           score = destroyedBricks;
        }
    }

    public int GetScore() {
        return this.score;
    }
    public int GetHighScore() {
        return this.highScore;
    }
    void SetHighScore() {
        if (score > highScore)
        {
            highScore = score;
        }
        PlayerPrefs.SetInt("highScore", highScore);
        print("current HighScore: " + highScore);
    }

    private void OnDestroy()
    {
        SetHighScore();
    }
}
