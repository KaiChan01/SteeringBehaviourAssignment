using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("changeToScene4", 10);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void changeToScene4()
    {
        SceneManager.LoadScene("Scene4");
    }
}
