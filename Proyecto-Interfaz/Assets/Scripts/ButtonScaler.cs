using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScaler: MonoBehaviour {
    public void ScaleUp () {
        LeanTween.scale (gameObject, new Vector3 (1.1f, 1.1f, 1.1f), 0.25f);
    }
    public void ScaleDown () {
        LeanTween.scale (gameObject, new Vector3 (1f, 1f, 1f), 0.25f);
    }
}