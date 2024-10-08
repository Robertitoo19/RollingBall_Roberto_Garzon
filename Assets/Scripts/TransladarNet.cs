using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransladarNet : MonoBehaviour
{
    [SerializeField] Vector3 direccion;
    [SerializeField] int velocidad;
    float timer = 0f;
    void Start()
    {

    }
    void Update()
    {
        transform.Translate(Time.deltaTime * velocidad * direccion);
        timer = timer + Time.deltaTime;

        if (timer >= 1.5f)
        {
            direccion = -direccion;
            timer = 0f;
        }
    }
}
