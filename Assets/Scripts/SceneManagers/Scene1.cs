using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1 : MonoBehaviour {

    private GameObject ship;

    // Use this for initialization
    void Start () {
        ship = GameObject.Find("MineSweeper");

    }
	
	// Update is called once per frame
	void Update () {
		if(ship.transform.position.z > 150)
        {
            SceneManager.LoadScene("Scene2");
        }
	}
}
