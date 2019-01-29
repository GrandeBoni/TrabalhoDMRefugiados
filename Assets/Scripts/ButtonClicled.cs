using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonClicled : MonoBehaviour {

    public void NextScene()
    {
        SceneManager.LoadScene("Historico_1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
