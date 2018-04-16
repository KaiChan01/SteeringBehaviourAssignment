using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightSeek : SteeringBehaviour
{

    public float distance;
    Vector3 target;

	// Use this for initialization
	void Start () {
        target = transform.position + (transform.forward * distance);
    }

    public void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, target);
    }

    // Update is called once per frame
    public override Vector3 calculateTarget()
    {
        return fighterPlane.seekTarget(target);
    }
}
