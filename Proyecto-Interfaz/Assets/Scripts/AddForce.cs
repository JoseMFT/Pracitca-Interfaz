using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce: MonoBehaviour {
    [SerializeField]
    Vector3 fuerza;
    Rigidbody body;
    void Start () {
        body = GetComponent<Rigidbody> ();
    }
    public void AddForces () {
        body.AddForce (fuerza, ForceMode.Impulse);
    }

    void Update () {
        if (Input.GetKey ("space"))
            body.AddForce (fuerza * Time.deltaTime, ForceMode.Impulse);
    }
}
