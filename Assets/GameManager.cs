using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    bool playing;
    float score;
    public Text scoreboard;

	// Use this for initialization
	void Start () {
        playing = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (playing)
        {
            score += Time.deltaTime;
            scoreboard.text = (int)score + "";
        }
        else
        {
            if((int)score > PlayerPrefs.GetInt("highscore")){
                PlayerPrefs.SetInt("highscore", (int)score);
            }
        }
	}

    public void ScoreUp()
    {
        score += 20;
    }
}
