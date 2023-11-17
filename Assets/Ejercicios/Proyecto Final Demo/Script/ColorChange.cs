using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class ColorChange : MonoBehaviour
{
   
    [SerializeField] Material material;

    [SerializeField] Material material2;

    [SerializeField] Material material3;

    [SerializeField] RawImage rawImage;


    Slider slider;

    private void Awake() {

        slider = GetComponent<Slider>();

    }

    private void Update() {

        material.SetColor("_Color", Color.HSVToRGB(slider.value, 1, 1));

        material2.SetColor("_Color", Color.HSVToRGB(slider.value, 1, 1));

        material3.SetColor("_Color", Color.HSVToRGB(slider.value, 1, 1));
        

        rawImage.color = material.GetColor("_Color");

        
    }
}
