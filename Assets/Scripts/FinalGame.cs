using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalGame : MonoBehaviour
{

	public int numX;

	public void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
	}

    // Update is called once per frame
    void Update()
    {
        if(numX >= 3)
		{
			SceneManager.LoadScene("Final");
		}
    }
}
