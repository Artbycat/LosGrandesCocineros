using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class ColoCHange : MonoBehaviour
{
    
    [SerializeField] VisualEffect vf;

    [SerializeField] Material material;

    [SerializeField] RawImage rawImage;

    VFXEventAttribute vfxEventAttribute;

    Slider slider;

    private void Awake() {

        slider = GetComponent<Slider>();

    }

    private void Start() {
        
        vfxEventAttribute = vf.CreateVFXEventAttribute();

    }
    private void Update() {

        material.SetColor("_Color", Color.HSVToRGB(slider.value, 1, 1));

        vf.SetVector4("Color", material.GetColor("_Color"));

        rawImage.color = material.GetColor("_Color");

        
    }

   
}
