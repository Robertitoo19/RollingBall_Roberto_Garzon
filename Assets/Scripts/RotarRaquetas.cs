using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarRaquetas : MonoBehaviour
{
    [SerializeField] Vector3 direccionRot;
    [SerializeField] int velocidadRot;
    float timer = 0f;
    void Start()
    {

    }
    void Update()
    {
        transform.Rotate(direccionRot * velocidadRot * Time.deltaTime, Space.World);
        timer = timer + Time.deltaTime;

        if (timer >= 1f)
        {
            direccionRot = -direccionRot;
            timer = 0f;
        }
    }
}
