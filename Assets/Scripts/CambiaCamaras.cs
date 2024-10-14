using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaCamaras : MonoBehaviour
{
    [SerializeField] private GameObject camAApagar;
    [SerializeField] private GameObject camAEncender;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.gameObject.CompareTag("Player"))
        {
            camAApagar.SetActive(false);

            camAEncender.SetActive(true);
        }
        else
        {
            camAApagar.SetActive(true);
            camAEncender.SetActive(false);
        }
    }

}
