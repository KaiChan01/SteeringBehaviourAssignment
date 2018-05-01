using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene9 : MonoBehaviour {

    public GameObject germanPlane;

    //Should be loop the loop
    private HalfLoopTurn loopScript;

    private ForwardWander wanderScript;

    // Use this for initialization
    void Start () {
        loopScript = germanPlane.GetComponent<HalfLoopTurn>();
        wanderScript = germanPlane.GetComponent<ForwardWander>();

        Invoke("toggleLoop", 3);
        Invoke("toggleLoop", 10);
        Invoke("changeToScene10", 12);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void toggleLoop()
    {
        loopScript.enabled = !loopScript.enabled;
        wanderScript.enabled = !wanderScript.enabled;
    }

    void changeToScene10()
    {
        SceneManager.LoadScene("Scene10");
    }
}
