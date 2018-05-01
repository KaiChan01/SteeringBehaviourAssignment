using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene9Cam : MonoBehaviour {

    public GameObject targetObject;
    public GameObject AttachedObject;
    public float yOffset;
    private float zOffset = 5;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        zOffset -= Time.deltaTime;
        Vector3 target2 = AttachedObject.transform.position + (Vector3.up * yOffset) + (Vector3.forward * -zOffset);
        transform.position = Vector3.Lerp(transform.position, target2, Time.deltaTime * 10);

        transform.LookAt(targetObject.transform.position);
    }


}
