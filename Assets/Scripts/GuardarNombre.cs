using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GuardarNombre : MonoBehaviour
{
    [SerializeField] TMP_InputField campoNombre;
    void Start()
    {
        
    }
    void Update()
    {
        if (campoNombre.text != "" && Input.GetKeyDown(KeyCode.Return))
        {
            PlayerPrefs.SetString("nombrePlayer",campoNombre.text);
            SceneManager.LoadScene("Videojuego");
        }
    }
}
