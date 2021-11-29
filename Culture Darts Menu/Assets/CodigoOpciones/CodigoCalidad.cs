﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodigoCalidad : MonoBehaviour
{ 
    public TMP_Dropdown dropdown;
    public int calidad;
    void Start()
    {
        calidad = PlayerPrefs.GetInt("numeroDeCalidad", 3);
        dropdown.value = calidad;
        AjustarCalidad();
    }

    void Update()
    {
        
    }
    public void AjustarCalidad()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numeroDeCalidad", dropdown.value);
        calidad = dropdown.value;
    }
}
