using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToStart : MonoBehaviour
{
	Camera camera;

	private void Start()
	{
		camera = Camera.main;
	}

	// Update is called once per frame
	void Update()
    {
		StartCoroutine(ToStart());
    }

	IEnumerator ToStart()
	{
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene("StartMenu");
	}
}
