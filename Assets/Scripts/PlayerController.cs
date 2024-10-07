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
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        puntos = 0;
    }
    void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            salto = new Vector3(0, 1, 0);
            rb.AddForce(salto * fuerzaSalto, ForceMode.Impulse);
        }

        
        movimiento = new Vector3(movX, 0, movZ);


        txtPnts.text = "x " + puntos.ToString(" 0");
    }
    private void FixedUpdate()
    {
        rb.AddForce(movimiento * fuerza);
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            Destroy(collision.gameObject);
            puntos++;
        }
    }
}
