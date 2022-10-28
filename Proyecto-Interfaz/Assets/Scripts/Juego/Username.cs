using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Username: MonoBehaviour {
    [SerializeField]
    TMP_InputField InputName;
    [SerializeField]
    TextMeshProUGUI NewUsername;
    [SerializeField]
    GameObject CanvasUI, Player;
    public void Ready () {
        CanvasUI.SetActive (true);
        Player.SetActive (true);
        gameObject.SetActive (false);
        NewUsername.text = InputName.text;

    }
}
