using UnityEngine;
using System.Collections;
public class MainMenu : MonoBehaviour {

    Rect screen;
    GUIStyle style;
    GUIStyle button;
    int panel = 0;
    public Texture2D logo;
    public Texture2D play_tex;
    public Texture2D exit_tex;

    // Use this for initialization
    void Start() {
        screen = new Rect(0, 0, Screen.width, Screen.height);
        style = new GUIStyle();
        style.fontSize = 124;
        style.alignment = TextAnchor.MiddleCenter;
        button = new GUIStyle();
        button.fixedWidth = Screen.width / 2;
        button.fixedHeight = Screen.height / 4;
        button.alignment = TextAnchor.MiddleCenter;
    }

    // Update is called once per frame
    void Update() {
    }

    void OnGUI() {
        GUILayout.BeginArea(screen);
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();
        GUILayout.FlexibleSpace();
        if(panel == 0) {
            GUILayout.Label("The Moon is\nFollowing You", style);

            GUILayout.FlexibleSpace();

            if (GUILayout.Button(play_tex, button))
            {
                Application.LoadLevel(1);
            }
            if (GUILayout.Button(exit_tex, button))
            {
                Application.Quit();
            }
        }
        GUILayout.FlexibleSpace();
        GUILayout.EndVertical();
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}
