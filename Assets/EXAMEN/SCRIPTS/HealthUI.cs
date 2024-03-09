using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    public Text health;

    private void Update()
    {
        health.text = "Vida: " + GameObject.FindWithTag("Player").GetComponent<Health>().health;
    }

    
}
