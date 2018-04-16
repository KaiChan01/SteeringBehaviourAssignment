using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purse : SteeringBehaviour {

    public GameObject target;
    private BaseSteering targetScript;

	// Use this for initialization
	void Start () {
        targetScript = target.GetComponent<BaseSteering>();
	}

    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, target.transform.position);
        }
    }

	
	// Update is called once per frame
	public override Vector3 calculateTarget()
    {
        //Distance from my position to target

        //float dist = Vector3.Distance(targetScript.transform.position, fighterPlane.transform.position);
        //float time = dist / fighterPlane.velocity.magnitude;

        Vector3 newTarget = targetScript.transform.position;

        return fighterPlane.seekTarget(newTarget);
    }
}
