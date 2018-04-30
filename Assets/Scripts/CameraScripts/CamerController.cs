using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour {

    public enum CamSetting{
        topDown,
        front
    }

    public GameObject targetObject;
    public float offsetDistance;
    public CamSetting cameraSetting;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        switch (cameraSetting)
        {
            case CamSetting.front:

                offsetDistance += 1 * Time.deltaTime;
                Vector3 target = targetObject.transform.position + (targetObject.transform.forward * offsetDistance) + (new Vector3(0, 5, 0));
                transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * 10);
                transform.LookAt(targetObject.transform.position);
                break;

            case CamSetting.topDown:
                offsetDistance -= 10 * Time.deltaTime;
                Vector3 target2 = targetObject.transform.position + (Vector3.up * offsetDistance);
                transform.position = Vector3.Lerp(transform.position, target2, Time.deltaTime * 10);
                transform.LookAt(targetObject.transform.position);
                break;
        }

            

    }
}
