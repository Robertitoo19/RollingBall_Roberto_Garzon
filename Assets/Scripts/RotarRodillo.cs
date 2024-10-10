using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarRodillo : MonoBehaviour
{
    [SerializeField] Vector3 direccionRot;
    [SerializeField] float FuerzaRot;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(direccionRot * FuerzaRot, ForceMode.VelocityChange);
    }
    void Update()
    {
        
    }
}
