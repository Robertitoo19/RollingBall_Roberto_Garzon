using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    [SerializeField] Vector3 direccionRot;
    [SerializeField] Vector3 direccionTrans;
    [SerializeField] int velocidadRot;
    [SerializeField] float velocidadTrans;
    float timer = 0f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(direccionRot * velocidadRot * Time.deltaTime, Space.World);
        transform.Translate(direccionTrans * velocidadTrans * Time.deltaTime, Space.World);
        timer = timer + Time.deltaTime;

        if (timer >= 0.3f)
        {
            direccionTrans = -direccionTrans;
            timer = 0f;
        }
    }
}
