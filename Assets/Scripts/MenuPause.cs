using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    [SerializeField] Canvas menuPausa;
    bool pause;
    void Start()
    {
        menuPausa.gameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausar();
        }
    }
    private void Pausar()
    {
        pause= !pause;
        menuPausa.gameObject.SetActive(pause);

        if (pause == true) 
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void Continue()
    {
        menuPausa.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
}
