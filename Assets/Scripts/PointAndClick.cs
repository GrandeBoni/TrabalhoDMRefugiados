using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointAndClick : MonoBehaviour
{
    private static HashSet<string> cenasVisitadas = new HashSet<string>();

    public void OnMouseDown()
    {
        switch (gameObject.tag)
        {
            case "Cena_Ida": cenaIda(); break;
            case "Cena_Volta": CenaVolta(); break;
            case "Cena_Alien": CenaDialogo(); break;
        }
    }

    void cenaIda()
    {
        string sceneName = gameObject.name;
        if ( !cenasVisitadas.Contains(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    void CenaVolta()
    {
            SceneManager.LoadScene("Inicio");
    }

    void CenaDialogo()
    {
        cenasVisitadas.Add(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(gameObject.name);

    }
 
}
