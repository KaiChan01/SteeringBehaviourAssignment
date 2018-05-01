using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfLoopTurn : SteeringBehaviour
{
    Vector3 worldTarget;
    //Vector3 pivotpoint;
    public float radius;
    public float frequency;

    Vector3 startingOrientation;
    float theta = 0f;

    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            //Gizmos.DrawLine(transform.position, pivotpoint);
            Gizmos.DrawLine(transform.position, worldTarget);
        }
    }

    // Use this for initialization
    void Start()
    {
        //pivotpoint = transform.position + Vector3.up * radius;
        startingOrientation = transform.forward;
    }

    void initEvasive()
    {
        
    }

    //Might change this to a child of a evade script, must find a way to call it and initialise and stop
    public override Vector3 calculateTarget()
    {
        Vector3 target;
        target.z = transform.position.z + Mathf.Cos(theta) * radius * startingOrientation.z;
        target.y = Mathf.Sin(theta) * radius + transform.position.y;
        target.x = transform.position.x + Mathf.Cos(theta) * radius * startingOrientation.x;

        theta += Time.deltaTime * frequency;
        worldTarget = target;
        return fighterPlane.seekTarget(worldTarget);
    }
}
