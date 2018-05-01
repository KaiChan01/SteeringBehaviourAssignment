using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scene6 : MonoBehaviour {


    public Camera cam1, cam2;

    // Use this for initialization
    void Start()
    {
        Invoke("changeCamera", 10);
        Invoke("changeToScene7", 20);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void changeCamera()
    {
        cam1.enabled = false;
        cam2.enabled = true;
    }

    void changeToScene7()
    {
        SceneManager.LoadScene("Scene7");
    }
}
