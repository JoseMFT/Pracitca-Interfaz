using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScaler: MonoBehaviour {
    public void ScaleUp () {
        LeanTween.scale (gameObject, new Vector3 (1.15f, 1.15f, 1.15f), 0.5f);
    }
    public void ScaleDown () {
        LeanTween.scale (gameObject, new Vector3 (1f, 1f, 1f), 0.5f);
    }
}