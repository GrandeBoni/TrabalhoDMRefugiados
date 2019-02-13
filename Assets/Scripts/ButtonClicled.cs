using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonClicled : MonoBehaviour {

    public void NextScene(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
