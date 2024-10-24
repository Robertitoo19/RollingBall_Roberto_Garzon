       using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedCubos : MonoBehaviour
{
    private bool iniciarTimer;
    private float timer = 0;
    [SerializeField] private Rigidbody[] rbs;
    void Update()
    {
        if (iniciarTimer)
        {
            timer = timer + Time.unscaledDeltaTime;

            if (timer >= 2f)
            {
                Time.timeScale = 1f;
                
                for (int i = 0; i < rbs.Length; i++)
                {
                    rbs[i].useGravity = true;
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.2f;
            iniciarTimer = true;
        }
    }
}
