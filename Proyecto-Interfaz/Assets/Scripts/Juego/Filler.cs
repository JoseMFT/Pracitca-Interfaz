using System.Collections; //https://github.com/Cheomm88/IntroUI
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Filler: MonoBehaviour {
    [SerializeField]
    GameObject textoProtegido;
    public bool escudo = false;
    public float tiempo;
    Image image;
    void Start () {
        image = GetComponent<Image> ();
        image.fillAmount = 0.5f;
    }

    // Update is called once per frame
    /*public void proteger () {
        for (tiempo = 4f; tiempo <= 0f; tiempo -= Time.deltaTime) {
            escudo = true;
            Debug.Log (tiempo);
            textoProtegido.SetActive (true);
        }
        textoProtegido.SetActive (false);
    }*/
    public void Fill (float vida) {
        image.fillAmount += vida;
    }
}
