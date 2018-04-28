using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("changeToScene3", 10);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void changeToScene3()
    {
        SceneManager.LoadScene("Scene3");
    }
}
