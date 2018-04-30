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
            Vector3 target = new Vector3(ship.transform.position.x, transform.position.y, ship.transform.position.z);
            return fighterPlane.seekTarget(target);
        }
        return Vector3.zero;
    }
}
