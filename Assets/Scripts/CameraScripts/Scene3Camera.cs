using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3Camera : MonoBehaviour {

    public GameObject ship;
    public GameObject lookAtTarget;
    public Vector3 offset;

	// Use this for initialization
	void Start () {
        transform.position = ship.transform.position + offset;

    }
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(lookAtTarget.transform.position);
        transform.position = ship.transform.position + offset;
    }
}
