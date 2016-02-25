using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    bool playing;
    float score;
    public Text scoreboard;

	// Use this for initialization
	void Start () {
        Data.gameState = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Data.gameState == 0)
        {
            score += Time.deltaTime;
            scoreboard.text = (int)score + "";
        }
	}

    void CheckScore()
    {
        if ((int)score > PlayerPrefs.GetInt("highscore0"))
        {
            PlayerPrefs.SetInt("highscore4", PlayerPrefs.GetInt("highscore3"));
            PlayerPrefs.SetInt("highscore3", PlayerPrefs.GetInt("highscore2"));
            PlayerPrefs.SetInt("highscore2", PlayerPrefs.GetInt("highscore1"));
            PlayerPrefs.SetInt("highscore1", PlayerPrefs.GetInt("highscore0"));
            PlayerPrefs.SetInt("highscore0", (int)score);
            return;
        }
        else if ((int)score > PlayerPrefs.GetInt("highscore1"))
        {
            PlayerPrefs.SetInt("highscore4", PlayerPrefs.GetInt("highscore3"));
            PlayerPrefs.SetInt("highscore3", PlayerPrefs.GetInt("highscore2"));
            PlayerPrefs.SetInt("highscore2", PlayerPrefs.GetInt("highscore1"));
            PlayerPrefs.SetInt("highscore1", (int)score);
            return;
        }
        else if ((int)score > PlayerPrefs.GetInt("highscore2"))
        {
            PlayerPrefs.SetInt("highscore4", PlayerPrefs.GetInt("highscore3"));
            PlayerPrefs.SetInt("highscore3", PlayerPrefs.GetInt("highscore2"));
            PlayerPrefs.SetInt("highscore2", (int)score);
            return;
        }
        else if ((int)score > PlayerPrefs.GetInt("highscore3"))
        {
            PlayerPrefs.SetInt("highscore4", PlayerPrefs.GetInt("highscore3"));
            PlayerPrefs.SetInt("highscore3", (int)score);
            return;
        }
        else if ((int)score > PlayerPrefs.GetInt("highscore4"))
        {
            PlayerPrefs.SetInt("highscore4", (int)score);
            return;
        }
    }

    public void Menu()
    {
        CheckScore();
        Application.LoadLevel(0);
    }

    public void ScoreUp()
    {
        score += 20;
    }
}
