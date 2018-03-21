using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SteeringBehaviour : MonoBehaviour {

    public Vector3 force;
    public float weight = 1.0f;

    private BaseSteering fighterPlane;

    public void Awake()
    {
        fighterPlane = GetComponent<BaseSteering>();
    }

    public abstract Vector3 calculateForce();
}
