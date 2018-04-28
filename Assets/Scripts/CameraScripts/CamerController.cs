using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour {

    public enum CamSetting{
        stationary,
        lookAt,
        follow,
    }

    public GameObject targetObject;
    public float offsetDistance;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        offsetDistance += 1 * Time.deltaTime;
        Vector3 target = targetObject.transform.position + (targetObject.transform.forward * offsetDistance) + (new Vector3(0, 5, 0));
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * 3);
        transform.LookAt(targetObject.transform.position);
    }
}
