using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalsDialogue : MonoBehaviour {

    public GameObject thiss;

	public GameObject numToFinal;
	// Use this for initialization
	void Start () {
		numToFinal = GameObject.FindGameObjectWithTag("ToFinal");
	}

    private void OnEnable()
    {
        Invoke("VoltaParaOInicio", 3.0f);
    }

    private void VoltaParaOInicio()
    {
        thiss.SetActive(false);
        SceneManager.LoadScene("Inicio");
		numToFinal.GetComponent<FinalGame>().numX++;
		//FinalGame.num++;

		//print(FinalGame.num);
    }
    
}
