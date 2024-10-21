using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float fuerza;
    [SerializeField] float fuerzaSalto;
    Vector3 movimiento;
    Vector3 salto;

    [SerializeField] TMP_Text txtPnts;
    private int puntos;
    private int Vidas = 3;

    Vector3 posiInicial;

    [SerializeField] private float radioRay;

    private float contador;
    private float segundos;
    private int minutos;
    [SerializeField] TMP_Text cronometro;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        puntos = 0;
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

        contador = contador + Time.deltaTime;
        segundos = contador;
        if (segundos >= 60)
        {
            segundos = 0;
            minutos++;
        }
        cronometro.text = minutos.ToString("00") + ":" + segundos.ToString("00");
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
            Debug.Log(Vidas);

            if (Vidas == 0)
            {
                transform.position = posiInicial;
                Vidas = 3;
            }
        }
    }
    private bool isGrounded()
    {
        bool resultado = Physics.Raycast(transform.position, Vector3.down, radioRay);
        Debug.DrawLine(transform.position, Vector3.down, Color.red, 2f);
        return resultado;
    }
}
