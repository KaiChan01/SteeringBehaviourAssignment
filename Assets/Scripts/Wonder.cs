using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wonder : SteeringBehaviour {

    Vector3 target;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void generateNewTarget()
    {
        if ((wonderTarget - fighterPlane.transform.position).magnitude < 10 || wonderTarget == Vector3.zero)
        {
            wonderTarget = new Vector3(Random.Range(fighterPlane.transform.position.x - 100, 
                fighterPlane.transform.position.x + 100), 
                Random.Range(minAltitude, maxAltitude), 
                Random.Range(fighterPlane.transform.position.y - 100, 
                transform.position.y + 100));
        }

        target = wonderTarget;
    }

    Vector3 calculateForce()
    {
        generateNewTarget();
        fighterPlane.seekTarget(target);
    }
}
