using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    int velocidadRot = 3;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 30, 10) * velocidadRot * Time.deltaTime);
    }
}
