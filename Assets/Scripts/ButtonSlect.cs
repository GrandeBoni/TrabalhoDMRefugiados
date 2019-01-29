using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSlect : MonoBehaviour {

    public GameObject Proximo;

    public void MouseOnDown()
    {    
        Proximo.SetActive(true);
        transform.parent.gameObject.SetActive(false);
    }
}
