using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GuardarNombre : MonoBehaviour
{
    [SerializeField] TMP_InputField campoNombre;
    void Start()
    {
        
    }
    void Update()
    {
        if (campoNombre.text != "")
        {
            PlayerPrefs.SetString("nombrePlayer",campoNombre.text);
        }
    }
}
