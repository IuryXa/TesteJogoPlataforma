using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoInteragivel : MonoBehaviour
{
    public int idObjeto;
    public Material[] materials;

    private HUD HUD;
    void Start()
    {
        HUD = GameObject.Find("HUD").GetComponent<HUD>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider colisao)
    {
        if(colisao.gameObject.name == "CabecaPlayer" && idObjeto==0)
        {
            this.gameObject.SetActive(false);
            HUD.Score += 10;
        }else if (colisao.gameObject.name == "CabecaPlayer" && idObjeto == 1)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = materials[0];
            HUD.Score += 10;
            HUD.moedas += 1;
        }
    }
}
