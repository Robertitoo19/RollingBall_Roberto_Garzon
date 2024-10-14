using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarRaquetas : MonoBehaviour
{

    private Rigidbody rb;
    float timer = 0f;
    [SerializeField] private float velocidadRotacion;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(RotarAObjetivo());
    }
    private IEnumerator RotarAObjetivo()
    {
        while(true)
        {
            float tiempoRotacion = 1f;
            while(timer < tiempoRotacion)
            {
                Quaternion deltaRotation = Quaternion.Euler(new Vector3(-1, 0, 0) * velocidadRotacion * Time.fixedDeltaTime);
                rb.MoveRotation(rb.rotation * deltaRotation);
                timer += Time.deltaTime;
                yield return new WaitForFixedUpdate();
            }
            timer = 0;

            yield return new WaitForSeconds(1f);

            while (timer < tiempoRotacion)
            {
                Quaternion deltaRotation = Quaternion.Euler(new Vector3(1, 0, 0) * velocidadRotacion * Time.fixedDeltaTime);
                rb.MoveRotation(rb.rotation * deltaRotation);
                timer += Time.deltaTime;
                yield return new WaitForFixedUpdate();
            }
            yield return new WaitForSeconds(1f);

            timer = 0;

            yield return new WaitForFixedUpdate();


        }
    }
}
