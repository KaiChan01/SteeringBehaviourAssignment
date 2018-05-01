using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene5Cam2 : MonoBehaviour {

    public GameObject attachTo;

    private Vector3 localTransform;

	// Use this for initialization
	void Start () {
        transform.position = attachTo.transform.position;
        transform.forward = attachTo.transform.forward * -1;
    }
	
	// Update is called once per frame
	void Update () {
        transform.LookAt((attachTo.transform.position) - (attachTo.transform.forward * 20));
        localTransform = attachTo.transform.position + (attachTo.transform.up * 1) + (attachTo.transform.forward * 3);
        transform.position = localTransform;
    }
}
