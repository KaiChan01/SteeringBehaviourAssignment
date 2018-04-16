using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SteeringBehaviour : MonoBehaviour {

    private Vector3 force;
    private float weight = 1.0f;

    [HideInInspector]
    public BaseSteering fighterPlane;

    public void Awake()
    {
        fighterPlane = GetComponent<BaseSteering>();
    }

    public abstract Vector3 calculateTarget();
}
