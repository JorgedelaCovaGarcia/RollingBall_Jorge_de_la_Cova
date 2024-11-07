using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuchillas : MonoBehaviour
{
    float timer = 0;
    [SerializeField] float velocidadM = 0;
    [SerializeField] float velocidadR = 0;
    [SerializeField] Vector3 direccionR;
    [SerializeField] Vector3 direccionM;

    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(direccionR * velocidadR * Time.deltaTime, Space.World);
        transform.Translate(direccionM.normalized * velocidadM * Time.deltaTime,Space.World);

        timer += Time.deltaTime;
        if (timer >= 1.5)
        {
            direccionM = -direccionM;
            timer = 0;
        }
    }
}
