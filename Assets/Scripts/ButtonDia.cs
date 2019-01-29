using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonDia : MonoBehaviour {

    public GameObject Alien ;
    public GameObject Astro;
    public GameObject Options;
    public GameObject Panel1;
    // Use this for initialization
    public void Clica () {
        Alien.SetActive(false);
        Astro.SetActive(true);
        Options.SetActive(true);
        Panel1.SetActive(false);
       
    }
	
}
