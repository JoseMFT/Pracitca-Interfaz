using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu: MonoBehaviour {

    [SerializeField]
    GameObject PlayerUI, Player, CanvasMenu;
    void Start () {

    }

    void activado () {
        Player.SetActive (false);
        PlayerUI.SetActive (false);
        if (CanvasMenu.activeSelf) {
            CanvasMenu.SetActive (false);
        } else {
            CanvasMenu.SetActive (true);
        }
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey ("esc")) {
            Player.SetActive (false);
            PlayerUI.SetActive (false);
            if (CanvasMenu.activeSelf) {
                CanvasMenu.SetActive (false);
            } else {
                CanvasMenu.SetActive (true);
            }
        }
    }
}
