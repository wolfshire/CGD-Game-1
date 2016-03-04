using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour {

    public GameObject titlePanel;
    public GameObject scorePanel;
    public GameObject helpPanel;
    int state = 0;
    public Text scoreboard;

    // Use this for initialization
    void Start() {
        InitializeScores();
    }

    void Update()
    {
        scoreboard.text = "Scoreboard:\n1: " + PlayerPrefs.GetInt("highscore0") + "\n2: " +
            PlayerPrefs.GetInt("highscore1") + "\n3: " + PlayerPrefs.GetInt("highscore2") + "\n4: " +
            PlayerPrefs.GetInt("highscore3") + "\n5: " + PlayerPrefs.GetInt("highscore4");
    }


    void InitializeScores()
    {
        if (!PlayerPrefs.HasKey("highscore0"))
        {
            PlayerPrefs.SetInt("highscore0", 0);
        }
        if (!PlayerPrefs.HasKey("highscore1"))
        {
            PlayerPrefs.SetInt("highscore1", 0);
        }
        if (!PlayerPrefs.HasKey("highscore2"))
        {
            PlayerPrefs.SetInt("highscore2", 0);
        }
        if (!PlayerPrefs.HasKey("highscore3"))
        {
            PlayerPrefs.SetInt("highscore3", 0);
        }
        if (!PlayerPrefs.HasKey("highscore4"))
        {
            PlayerPrefs.SetInt("highscore4", 0);
        }
    }

    public void LoadGame()
    {
        Application.LoadLevel(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Scoreboard()
    {
        titlePanel.SetActive(false);
        scorePanel.SetActive(true);
        state = 1;
    }

    public void Help()
    {
        titlePanel.SetActive(false);
        helpPanel.SetActive(true);
        state = 2;
    }

    public void MainScreen()
    {
        scorePanel.SetActive(false);
        helpPanel.SetActive(false);
        titlePanel.SetActive(true);
        state = 0;
    }
}
