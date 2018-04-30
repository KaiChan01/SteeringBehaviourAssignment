using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scene4 : MonoBehaviour {

    public GameObject leaderPlane;
    public Camera cam1, cam2;
    private AdjustToTarget targetScript;

    // Use this for initialization
    void Start () {
        targetScript = leaderPlane.GetComponent<AdjustToTarget>();
        Debug.Log("called");
        Invoke("activateLockOnTarget", 4);
        Invoke("switchCamera", 12);
        //Invoke("changeToScene5", 4);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void activateLockOnTarget()
    {
        targetScript.enabled = true;
    }

    void changeToScene5()
    {
        SceneManager.LoadScene("Scene5");
    }

    void switchCamera()
    {
        cam1.enabled = false;
        cam2.enabled = true;
    }
}
