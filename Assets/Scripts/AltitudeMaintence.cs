using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltitudeMaintence : SteeringBehaviour
{

    public float frequency = 2f;
    public float amp = 2f;
    public float radius = 10;
    public float distance = 15;
    public float reAdjustForce;

    public float roationSpeed;

    Vector3 worldTarget;

    float theta;

    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, worldTarget);
        }
    }

    // Use this for initialization
    void Start()
    {
    }

    public override Vector3 calculateTarget()
    {
        if(fighterPlane.transform.position.y > fighterPlane.maxAltitude)
        {
            worldTarget = new Vector3(transform.position.x, transform.position.y - reAdjustForce, transform.position.z);
            return fighterPlane.seekTarget(worldTarget);
        }

        if(fighterPlane.transform.position.y < fighterPlane.minAltitude)
        {
            worldTarget = new Vector3(transform.position.x, transform.position.y + reAdjustForce, transform.position.z);
            return fighterPlane.seekTarget(worldTarget);
        }

        //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.time * roationSpeed);

        return Vector3.zero;
    }
}
