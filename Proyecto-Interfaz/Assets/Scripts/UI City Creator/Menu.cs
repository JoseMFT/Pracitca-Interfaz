//Este código realiza las animaciones que tienen lugar al abrir el menú de opciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu: MonoBehaviour {

    [SerializeField]
    GameObject canvasInicio, cambiarIdiomas, cruzSalir;
    void OnEnable () {
        canvasInicio.SetActive (false);
        LeanTween.alphaCanvas (gameObject.GetComponent<CanvasGroup> (), 0f, 0f);
        LeanTween.scale (cambiarIdiomas, new Vector3 (0.0f, 0.0f, 0.0f), 0.0f);
        LeanTween.scale (cruzSalir, new Vector3 (0.0f, 0.0f, 0.0f), 0.0f);
        LeanTween.alphaCanvas (gameObject.GetComponent<CanvasGroup> (), 1f, 0.25f);
        LeanTween.scale (cambiarIdiomas, new Vector3 (2.5f, 2.5f, 1.0f), 0.25f);
        LeanTween.scale (cruzSalir, new Vector3 (0.21f, 1.0f, 1.1f), 0.25f);

    }
    public void cerrar () {
        LeanTween.alphaCanvas (gameObject.GetComponent<CanvasGroup> (), 0f, 0.5f).setOnComplete (() => {
            canvasInicio.SetActive (true);
            gameObject.SetActive (false);
        });
    }
}
