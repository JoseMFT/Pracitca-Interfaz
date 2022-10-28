//Este código escala los distintos botones con los que podamos interactuar
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

    public void CrossScaleUp () {
        LeanTween.scale (gameObject, new Vector3 (0.23f, 1.1f, 1.1f), 0.25f);
    }

    public void CrossScaleDown () {
        LeanTween.scale (gameObject, new Vector3 (0.21f, 1.0f, 1.1f), 0.25f);
    }

    public void ArrowScaleUp () {
        LeanTween.scale (gameObject, new Vector3 (1.0f, 1.0f, 1.1f), 0.25f);
    }

    public void ArrowScaleDown () {
        LeanTween.scale (gameObject, new Vector3 (0.9f, 0.9f, 1.1f), 0.25f);
    }
}