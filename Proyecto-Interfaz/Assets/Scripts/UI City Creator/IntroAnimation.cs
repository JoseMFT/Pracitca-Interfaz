//Este c�digo hace la animaci�n que se da lugar al inicar el juego
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAnimation: MonoBehaviour {

    [SerializeField]
    GameObject Logo;
    [SerializeField]
    GameObject OpeningMenu;

    void Start () {
        LeanTween.moveLocalY (Logo, -750f, 0.0f);
        LeanTween.moveLocal (Logo, new Vector3 (20f, 21, 0f), 1.5f).setEaseOutCubic ().setOnComplete (Scale);
    }
    void Scale () {
        LeanTween.scale (Logo, Vector3.one * 3, 0.2f).setEaseInBack ();
        LeanTween.alphaCanvas (gameObject.GetComponent<CanvasGroup> (), 0.0f, 1.4f).setOnComplete (Desactivar);
    }


    void Desactivar () {
        OpeningMenu.SetActive (true);
        gameObject.SetActive (false);

    }
}
