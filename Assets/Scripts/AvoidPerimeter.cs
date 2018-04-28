using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidPerimeter : SteeringBehaviour
{
    public float maxDistFromShip;
    public float preferedDistanceFromShip;
    public GameObject ship;

    // Use this for initialization
    void Start() {

    }

    public override Vector3 calculateTarget()
    {
        if (Vector3.Distance(fighterPlane.transform.position, ship.transform.position) > maxDistFromShip)
        {
            return fighterPlane.seekTarget(ship.transform.position);
        }
        return Vector3.zero;
    }
}
