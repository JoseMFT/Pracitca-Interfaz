using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu: MonoBehaviour {

    [SerializeField]
    GameObject canvasMenu, canvasInicio;
    public void clicked () {
        canvasMenu.SetActive (true);
        LeanTween.alphaCanvas (canvasMenu.GetComponent<CanvasGroup> (), 0.0f, 0.0f);
        LeanTween.scale (canvasMenu, new Vector3 (0.0f, 0.0f, 0.0f), 0.0f).setOnComplete (aparecer);
    }

    void aparecer () {
        canvasInicio.SetActive (false);
        LeanTween.scale (canvasMenu, new Vector3 (1f, 1f, 1f), 0.5f);
        LeanTween.alphaCanvas (canvasMenu.GetComponent<CanvasGroup> (), 1f, 0.35f);
    }

    public void cerrar () {
        canvasInicio.SetActive (true);
        LeanTween.scale (canvasMenu, new Vector3 (0f, 0f, 0f), 0.35f);
        LeanTween.alphaCanvas (canvasMenu.GetComponent<CanvasGroup> (), 0f, 0.5f);
        canvasMenu.SetActive (false);
    }
}
