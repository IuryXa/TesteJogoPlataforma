using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InimigoBehavior : MonoBehaviour
{
    bool atingiuObstaculo =false;
    public float velocidadeMovimento;

    private HUD HUD;
    private float tempoMorto=2;
    private Vector3 escala;
    private Vector3 posicao;
    private bool vivo = true;
    // Start is called before the first frame update
    void Start()
    {
        escala = new Vector3(0, 0.7f, 0);
        posicao = new Vector3(0, 0.3f, 0);
        HUD = GameObject.Find("HUD").GetComponent<HUD>();
    }

    public void Morreu()
    {
        vivo = false;
        this.GetComponent<Rigidbody>().useGravity = false;
        this.GetComponent<SphereCollider>().enabled = false;
        this.gameObject.transform.localScale -= escala;
        this.gameObject.transform.position -= posicao;
        tempoMorto = Time.time + tempoMorto;
        HUD.Score += 250;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>tempoMorto && vivo==false)
        {
            this.gameObject.SetActive(false);
        }
        if (atingiuObstaculo == false && vivo)//Sempre começa indo em direção a esquerda
        {
            transform.Translate(-velocidadeMovimento,0,0);
        }
        else if (atingiuObstaculo == true && vivo)
        {
            transform.Translate(velocidadeMovimento, 0, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Obstaculo" && atingiuObstaculo ==false) 
        {
            atingiuObstaculo=true;
        }else if (collision.gameObject.name =="Obstaculo" && atingiuObstaculo == true)
        {
            atingiuObstaculo=false;
        }
        if (collision.gameObject.name == "Player" && vivo)
        {
            SceneManager.LoadScene(1);
        }
    }
}
