using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MostrarNombre : MonoBehaviour
{
    [SerializeField] TMP_Text nombre;
    [SerializeField] TMP_Text tiempo;
    private int minutos;
    private float segundos;
    void Start()
    {
        
    }
    void Update()
    {
        nombre.text = PlayerPrefs.GetString("nombrePlayer");
        minutos = PlayerPrefs.GetInt("PuntuacionM");
        segundos = PlayerPrefs.GetFloat("PuntuacionS");
        tiempo.text = minutos.ToString("00") + ":" + Mathf.Floor(segundos).ToString("00");
    }
}
