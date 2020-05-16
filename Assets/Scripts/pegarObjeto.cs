using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegarObjeto : MonoBehaviour
{
    public GameObject[] objetos;
    public Animator controle;


    void Start()
    {
        GameObject jogador = Instantiate(objetos[codigoEscolha.jogadorSelecionado], transform.position, transform.rotation);
        controle = jogador.GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            controle.SetTrigger("pRodar");
        }
        
    }

}
