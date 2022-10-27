using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningMenu: MonoBehaviour {
    [SerializeField]
    GameObject Logo;
    [SerializeField]
    GameObject Buttons;
    void OnEnable () {
        LeanTween.moveLocalX (Logo, 400f, 0.0f);
        LeanTween.moveLocalY (Logo, 85f, 1f).setLoopPingPong ();
        LeanTween.moveLocalX (Buttons, -400f, 0.0f).setOnComplete (Entrance);
    }

    void Entrance () {
        LeanTween.moveLocalX (Logo, -25f, .5f);
        LeanTween.moveLocalX (Buttons, 0f, .5f);
    }
}
