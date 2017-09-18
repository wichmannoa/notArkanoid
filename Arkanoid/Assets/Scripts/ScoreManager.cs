using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    //Looks at the gameStatus to update the score Text;
    public Text score;
    public Text highScore;
    public GameStatus gameStatus;

	void Update () {
        if (!score)
        {
        }
        else {
            score.text = gameStatus.GetScore().ToString();
        }
        if (!highScore)
        {
        }
        else
        {
            highScore.text = "HIGH SCORE: " + gameStatus.GetHighScore().ToString();
        }

    }
}
