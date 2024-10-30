using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    [Header("-----Movimiento y Salto-----")]
    [SerializeField] float fuerza;
    [SerializeField] float fuerzaSalto;
    Vector3 movimiento;
    Vector3 salto;

    [Header("-----Puntos Y Vidas-----")]
    [SerializeField] TMP_Text txtPnts;
    private int puntos = 0;
    private int Vidas = 3;
    [SerializeField] GameObject[] corazonesVida;

    Vector3 posiInicial;

    [SerializeField] private float radioRay;

    [Header("-----Contador-----")]
    private float segundos;
    private int minutos;
    [SerializeField] TMP_Text cronometro;

    [Header("-----Audio-----")]
    [SerializeField] AudioManager audioManager;
    public AudioClip[] sonidos;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        txtPnts.text = ("x " + puntos);
        posiInicial = transform.position;
    }
    void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            salto = new Vector3(0, 1, 0);
            rb.AddForce(salto * fuerzaSalto, ForceMode.Impulse);
        }
 
        movimiento = new Vector3(movX, 0, movZ);

        segundos += Time.deltaTime;
        if (segundos >= 60)
        {
            segundos = 0;
            minutos++;
        }
        cronometro.text = minutos.ToString("00") + ":" + Mathf.Floor(segundos).ToString("00");

    }
    private void FixedUpdate()
    {
        rb.AddForce(movimiento * fuerza);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            Destroy(other.gameObject);
            puntos++;
            txtPnts.text = "x " + puntos;
            audioManager.ReproducirSFX(sonidos[2]);
        }
        if (other.gameObject.CompareTag("Win") && puntos >= 7)
        {
            PlayerPrefs.SetInt("PuntuacionM", minutos); 
            PlayerPrefs.SetFloat("PuntuacionS", Mathf.Floor(segundos)); 
            SceneManager.LoadScene(2);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Vacio"))
        {
            transform.position = posiInicial;
        }
    }
    private void OnCollisionEnter(Collision choque)
    {
        if (choque.gameObject.CompareTag("Trampa"))
        {
            Vidas--;
            SistemaVidas();
            audioManager.ReproducirSFX(sonidos[3]);
        }
        if (choque.gameObject.CompareTag("TrampaPincho"))
        {
            Vidas--;
            SistemaVidas();
            audioManager.ReproducirSFX(sonidos[4]);
        }
        if (choque.gameObject.CompareTag("Suelo"))
        {
            audioManager.ReproducirSFX(sonidos[1]);
        }

    }
    private void SistemaVidas()
    {
        if (Vidas == 3)
        {
            corazonesVida[0].SetActive(true);
            corazonesVida[1].SetActive(true);
            corazonesVida[2].SetActive(true);
        }
         else if (Vidas == 2)
        {
            corazonesVida[0].SetActive(true);
            corazonesVida[1].SetActive(true);
            corazonesVida[2].SetActive(false);
        }
        else if (Vidas == 1)
        {
            corazonesVida[0].SetActive(true);
            corazonesVida[1].SetActive(false);
            corazonesVida[2].SetActive(false);
        }
        else if (Vidas == 0)
        {
            transform.position = posiInicial;
            Vidas = 3;
            corazonesVida[0].SetActive(true);
            corazonesVida[1].SetActive(true);
            corazonesVida[2].SetActive(true);
        }
    }
    private bool isGrounded()
    {
        bool resultado = Physics.Raycast(transform.position, Vector3.down, radioRay);
        Debug.DrawLine(transform.position, Vector3.down, Color.red, 2f);
        return resultado;
    }
}
