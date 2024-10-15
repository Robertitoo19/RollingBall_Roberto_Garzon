using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenemanagement : MonoBehaviour
{
    public void Nombre()
    {
        SceneManager.LoadScene("IntroducirNombre");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Play()
    {
        SceneManager.LoadScene("Videojuego");
    }
    public void Puntuacion()
    {
        SceneManager.LoadScene("Puntuacion");
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Chao");
    }
}
