using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    [SerializeField] private GameObject CamApagar;
    [SerializeField] private GameObject CamEncender;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CamApagar.SetActive(false);
            CamEncender.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        CamApagar.SetActive(true);
        CamEncender.SetActive(false);
    }
}
