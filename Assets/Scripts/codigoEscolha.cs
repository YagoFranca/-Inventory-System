using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class codigoEscolha : MonoBehaviour
{

    [Header("0 - esfera, 1 - cubo,2 - cilindro")]
    public static int jogadorSelecionado;

    public void escolherObjeto(int objeto)
    {
        jogadorSelecionado = objeto;
        SceneManager.LoadScene(1);
    }
   
}
