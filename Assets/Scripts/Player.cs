using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float fuerza;
    [SerializeField] float fuerzaSalto;
    [SerializeField] int distanciaRaycast;
    Rigidbody rb;
    Vector3 miVector = new Vector3 (0, 1, 0);

    float h, v;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.mass = 5;
        rb.isKinematic = false;
        rb.drag = 4f;

    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown (KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 1, 0) * fuerzaSalto, ForceMode.Impulse);
        }
    }
    void FixedUpdate()
    {
        rb.AddForce(new Vector3 (h, 0, 0) * fuerza, ForceMode.Force);
        rb.AddForce(new Vector3(0, 0, v) * fuerza, ForceMode.Force);

    }
    private bool DetectaSuelo()
    {
        bool resultado = Physics.Raycast(transform.position, Vector3.down, distanciaRaycast);
        Debug.DrawRay(transform.position, Vector3.down, Color.yellow, 2f);
        return resultado;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Reset"))
        {
            Teleport();
        }
        else if (collision.gameObject.CompareTag("Reset2"))
        {
            Teleport2();
        }
    }

    private void Teleport()
    {
        transform.position = new Vector3 (-0.62f,16.03f,-1.45f);
    }

    private void Teleport2()
    {
        transform.position = new Vector3(1.44f, 7.88f, 31.81f);
    }
}
