using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenemanagement : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Videojuego");
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Chao");
    }
}
