using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalsDialogue : MonoBehaviour {
    public int timeFinal;

    public GameObject Esse;
	// Use this for initialization
	void Start () {
        timeFinal = 0;
	}

    private void OnEnable()
    {
        Invoke("VoltaParaOInicio", 3.0f);
    }

    private void VoltaParaOInicio()
    {
        SceneManager.LoadScene("Inicio");
        Esse.SetActive(false);
    }
    
}
