using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trasladar : MonoBehaviour
{
    [SerializeField] Vector3 direccion;
    int velocidad = 3;
    void Start()
    {

    }
    void Update()
    {
        transform.Translate(Time.deltaTime * velocidad * direccion);
    }
}
