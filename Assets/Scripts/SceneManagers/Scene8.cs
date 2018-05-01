using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene8 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Invoke("changeToScene9", 15);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void changeToScene9()
    {
        SceneManager.LoadScene("Scene9");
    }
}
