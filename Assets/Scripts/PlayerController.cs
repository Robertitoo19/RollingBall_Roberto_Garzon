using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float fuerza;

    [SerializeField] TMP_Text txtPnts;
    private int puntos;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        puntos = 0;
    }
    void Update()
    {
        txtPnts.text = "x " + puntos.ToString(" 0");
    }
    private void FixedUpdate()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movX, 0, movY);

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
