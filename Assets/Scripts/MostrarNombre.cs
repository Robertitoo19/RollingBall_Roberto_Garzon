using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MostrarNombre : MonoBehaviour
{
    [SerializeField] TMP_Text nombre;
    [SerializeField] TMP_Text tiempo;
    void Start()
    {
        
    }
    void Update()
    {
        nombre.text = PlayerPrefs.GetString("nombrePlayer");
        tiempo.text = PlayerPrefs.GetFloat("Puntuacion").ToString();
    }
}
