using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float fuerza;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }
    void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movX, 0, movY);

        rb.AddForce(movimiento * fuerza);
    }
}
