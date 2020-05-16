using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public GameObject[] armaAtual;
    private GameObject naMao;
    public Transform mao;

    public GameObject[] botoesCanvas;


    private bool canvasligado = true;

    void Start()
    {
       naMao = Instantiate(armaAtual[0], mao.transform);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ligaredesligarCanvas();
        }
    }

    void ligaredesligarCanvas()
    {
        canvasligado = !canvasligado;

        for(int I = 0; I < botoesCanvas.Length; I++)
        {
            botoesCanvas[I].gameObject.SetActive(canvasligado);
        }

    }

    public void trocaArma (int tA)
    {
      Destroy(naMao);
      naMao = Instantiate(armaAtual[tA], mao.transform);
    }
}
