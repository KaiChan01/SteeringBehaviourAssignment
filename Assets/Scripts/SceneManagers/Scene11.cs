using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene11 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("gracefullyExit", 15);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void gracefullyExit()
    {
        Application.Quit();
    }
}
