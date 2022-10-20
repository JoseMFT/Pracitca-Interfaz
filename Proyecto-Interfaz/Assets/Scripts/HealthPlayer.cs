using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer: MonoBehaviour {
    [SerializeField]
    Slider sliderHealth;
    [SerializeField]
    int MAX_HEALTH = 20;
    [SerializeField]
    int currentHealth = 5;

    void Start () {
        sliderHealth.value = MAX_HEALTH / 2;
    }
    public void Fill (int vida) {
        sliderHealth.value += vida;
    }
}
