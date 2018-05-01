using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scene5 : MonoBehaviour {

    public GameObject spitfire1, spitfire2, spitfire3;
    private Purse p1, p2, p3;
    private ForwardWander fw1, fw2, fw3;
    private AdjustToTarget adjust1, adjust2, adjust3;

    public Camera cam1, cam2;

    // Use this for initialization
    void Start()
    {
        p1 = spitfire1.GetComponent<Purse>();
        p2 = spitfire2.GetComponent<Purse>();
        p3 = spitfire3.GetComponent<Purse>();

        fw1 = spitfire1.GetComponent<ForwardWander>();
        fw2 = spitfire2.GetComponent<ForwardWander>();
        fw3 = spitfire3.GetComponent<ForwardWander>();

        adjust1 = spitfire1.GetComponent<AdjustToTarget>();
        adjust2 = spitfire2.GetComponent<AdjustToTarget>();
        adjust3 = spitfire3.GetComponent<AdjustToTarget>();


        Invoke("beginPurse", 10);
        Invoke("changeCamera", 16);
        Invoke("changeToScene6", 25);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void beginPurse()
    {
        p1.enabled = p2.enabled = p3.enabled = true;
        adjust1.enabled = adjust2.enabled = adjust3.enabled = false;
        fw1.enabled = fw2.enabled = fw3.enabled = false;
    }

    void changeCamera()
    {
        cam1.enabled = false;
        cam2.enabled = true;
    }

    void changeToScene6()
    {
        SceneManager.LoadScene("Scene6");
    }
}
