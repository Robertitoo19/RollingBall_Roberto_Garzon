using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenemanagement : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject sliderMenu;
    [SerializeField] private GameObject inputMenu;
    public void Slider()
    {
        mainMenu.SetActive(false);
        sliderMenu.SetActive(true);
        inputMenu.SetActive(false);
    }
    public void Nombre()
    {
        mainMenu.SetActive(false);
        sliderMenu.SetActive(false);
        inputMenu.SetActive(true);
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
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
