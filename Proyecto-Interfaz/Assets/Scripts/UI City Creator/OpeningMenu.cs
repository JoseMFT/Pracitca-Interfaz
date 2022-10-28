//Este código realiza la animación que tiene lugar al entrar a la pantalla de inicio
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningMenu: MonoBehaviour {

    [SerializeField]
    GameObject Logo, ButtonPlay, ButtonSettings, ButtonExit;

    void OnEnable () {
        //LeanTween.scale (ButtonPlay, new Vector3 (0.0f, 0.0f, 0.0f), 0.0f);
        //LeanTween.scale (ButtonSettings, new Vector3 (0.0f, 0.0f, 0.0f), 0.0f);
        //LeanTween.scale (ButtonExit, new Vector3 (0.0f, 0.0f, 0.0f), 0.0f);
        //  LeanTween.moveLocalX (Logo, 400f, 0.0f).setOnComplete (Entrance);
        //Play ();


    }

    void Entrance () {
        LeanTween.moveLocalX (Logo, -25f, 1.5f).setEaseOutBounce ().setOnComplete (Play);
        LeanTween.moveLocalY (Logo, 170f, 1.5f).setLoopPingPong ();
    }

    void Play () {
        LeanTween.scale (ButtonPlay, new Vector3 (1.0f, 1.0f, 1.0f), 0.75f).setOnComplete (Settings);
    }

    void Settings () {
        LeanTween.scale (ButtonSettings, new Vector3 (1.0f, 1.0f, 1.0f), 0.75f).setOnComplete (Exit);
    }

    void Exit () {
        LeanTween.scale (ButtonExit, new Vector3 (1.0f, 1.0f, 1.0f), 0.75f);
    }

    public void Finish () {
        Application.Quit ();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
