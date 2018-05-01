using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene10 : MonoBehaviour {

    public GameObject explodePlane;
    public GameObject chasingPlane1;
    public GameObject chasingPlane2;

    private AltitudeMaintence altitudeScript;
    private Purse purse1, purse2;
    ParticleSystem exp;

    // Use this for initialization
    void Start()
    {
        exp = explodePlane.GetComponent<ParticleSystem>();
        purse1 = chasingPlane1.GetComponent<Purse>();
        purse2 = chasingPlane2.GetComponent<Purse>();

        altitudeScript = explodePlane.GetComponent<AltitudeMaintence>();
        Invoke("explode", 4);
    }

    // Update is called once per frame
    void Update()
    {
        if (explodePlane.transform.position.y < 0)
        {
            changeToScene11();
        }
    }

    void explode()
    {
        exp.Play();
        altitudeScript.enabled = true;
        purse1.enabled = purse2.enabled = false;
    }

    void changeToScene11()
    {
        SceneManager.LoadScene("Scene11");
    }
}
