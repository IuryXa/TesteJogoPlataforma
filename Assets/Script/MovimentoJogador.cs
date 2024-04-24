using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{
    public float velocidadeMovimento;
    public Vector3 pulo;
    public bool noChao = false;
    public float velocidadeCorrida;

    private Rigidbody rb;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        pulo = new Vector3(0, 5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float velocidadeAtual = velocidadeMovimento;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocidadeAtual *= velocidadeCorrida;
        }

        if (Input.GetAxisRaw("Horizontal")>0)
        {
            transform.Translate(velocidadeAtual, 0, 0);
        } else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(-velocidadeAtual, 0,0);
        }
        if (Input.GetAxisRaw("Vertical") > 0 && noChao)
        {
            rb.AddForce(pulo, ForceMode.Impulse);
            noChao = false;
        }
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Chao")
        {
            noChao = true;
        }else if(collision.gameObject.name == "Obstaculo")
        {
            noChao = true;
        }
        else if (collision.gameObject.name == "PontaCano")
        {
            noChao = true;
        }
    }
}
