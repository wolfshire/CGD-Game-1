using UnityEngine;
using System.Collections;
public class MainMenu : MonoBehaviour {

    Rect screen;
    GUIStyle style;
    GUIStyle button;
    int panel = 0;
    Texture2D start_button;
    Texture2D exit_button;

    // Use this for initialization
    void Start() {
        screen = new Rect(0, 0, Screen.width, Screen.height);
        style = new GUIStyle();
        style.fontSize = 64;
        style.alignment = TextAnchor.UpperCenter;
        button = new GUIStyle();
        button.fixedWidth = Screen.width / 2;
        button.fixedHeight = Screen.height / 4;
    }

    // Update is called once per frame
    void Update() {
    }

    void OnGUI() {
        GUILayout.BeginArea(screen, style);
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();
        if(panel == 0) {
            GUILayout.Label("The Moon is\nFollowing You!",style);
            
            if (GUILayout.Button("Start Game",button))
            {
                Application.LoadLevel(1);
            }
            if (GUILayout.Button("Exit", button))
            {
                Application.Quit();
            }
        }
        GUILayout.EndVertical();
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}
