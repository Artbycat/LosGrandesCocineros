using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccesoAlShader : MonoBehaviour
{
	public Renderer rend;

	public Material mat;
	public Slider slide;
	public float numerito;

void Start () 
{
	
}

void Update ()
{
	rend.material.SetFloat("_Offset", numerito );
	mat.SetFloat("_Offset",numerito);
}

public void Slider ()
{
  numerito = slide.value;
}

}