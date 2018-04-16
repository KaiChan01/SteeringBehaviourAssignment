using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : SteeringBehaviour {

    Vector3 wanderTarget;

    // Use this for initialization
    void Start () {
        wanderTarget = new Vector3(
        Random.Range(fighterPlane.transform.position.x - 100, fighterPlane.transform.position.x + 100),
        Random.Range(fighterPlane.minAltitude, fighterPlane.maxAltitude),
        Random.Range(fighterPlane.transform.position.z - 100, fighterPlane.transform.position.z + 100));
    }


    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, wanderTarget);
        }
    }

    // Update is called once per frame
    void generateNewTarget()
    {
        if (Vector3.Distance(wanderTarget, fighterPlane.transform.position) < 10)
        {
            wanderTarget = new Vector3(Random.Range(fighterPlane.transform.position.x - 100, fighterPlane.transform.position.x + 100), 
            Random.Range(fighterPlane.minAltitude, fighterPlane.maxAltitude), 
            Random.Range(fighterPlane.transform.position.z - 100, fighterPlane.transform.position.z + 100));
        }
    }

    public override Vector3 calculateTarget()
    {
        generateNewTarget();
        return fighterPlane.seekTarget(wanderTarget);
    }
}
