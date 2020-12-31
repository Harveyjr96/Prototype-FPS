﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    Image image;
    public Life targetLife;
    // Start is called before the first frame update
    void Awake() {
        image = GetComponent<Image>();
    }
    void Update() {
        image.fillAmount = targetLife.amount / 100;
    }

}
