using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarSceneCanoOuPole : MonoBehaviour
{
    public bool emcima = false;
    public bool eMastro;
    public bool eMoeda;
    private HUD HUD;
    void Start()
    {
        HUD = GameObject.Find("HUD").GetComponent<HUD>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") < 0 && emcima)
        {
            Debug.Log("O Player entrou no cano");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name=="Player" && eMastro)
        {
            Debug.Log("O Player passou de fase");
        }
        if(collision.gameObject.name == "Player" && eMoeda)
        {
            HUD.moedas += 1;
            this.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "Player")
        {
            emcima = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            emcima = false;
        }
    }
}
