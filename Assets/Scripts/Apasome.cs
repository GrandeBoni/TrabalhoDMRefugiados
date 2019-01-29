using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;

public class Apasome : MonoBehaviour {

    public GameObject Painel1;
    public GameObject Painel2;
    public GameObject Painel3;
    public GameObject textPanel2;
    public GameObject Painel4;
    
    //public GameObject Botao;

    public void EscondePainel()
    {
        Painel1.SetActive(true);

        Painel2.SetActive(false);
        //Botao.GetComponent<Button>().interactable = true;
    }

}
