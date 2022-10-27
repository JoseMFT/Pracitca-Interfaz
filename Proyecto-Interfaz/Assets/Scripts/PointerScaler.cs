using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerScaler: MonoBehaviour {
    public void MoveLeft () {
        LeanTween.scale (gameObject, new Vector3 (1.1f, 1.1f, 1.1f), 0.25f);
        LeanTween.moveLocalX (gameObject, 37.5f, 0.25f);
    }

    public void MoveRight () {
        LeanTween.scale (gameObject, new Vector3 (1.1f, 1.1f, 1.1f), 0.25f);
        LeanTween.moveLocalX (gameObject, 90f, 0.25f);
    }

    public void MoveBackLeft () {
        LeanTween.moveLocalX (gameObject, 38.75f, 0.25f);
        LeanTween.scale (gameObject, new Vector3 (0.9f, 0.9f, 1f), 0.25f);
    }

    public void MoveBackRight () {
        LeanTween.moveLocalX (gameObject, 88.75f, 0.25f);
        LeanTween.scale (gameObject, new Vector3 (0.9f, 0.9f, 1f), 0.25f);
    }
}