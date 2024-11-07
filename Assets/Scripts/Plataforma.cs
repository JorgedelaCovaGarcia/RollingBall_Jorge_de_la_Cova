using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    float timer = 0;
    [SerializeField] int velocidad = 2;
    [SerializeField] Vector3 direccion;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(direccion.normalized * velocidad * Time.deltaTime);
        timer += Time.deltaTime;
        if(timer >= 5)
        {
            direccion = -direccion;
            timer = 0;
        }
    }
}
