using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSteering : MonoBehaviour
{

    public GameObject target;

    public int maxAltitude;
    public int minAltitude;
    public int flyingSpeed;
    public float mass;

    public bool wonder;

    //We'll hard code force for now;
    public Vector3 force = Vector3.zero;
    public Vector3 velocity = Vector3.zero;
    public Vector3 wonderTarget = Vector3.zero;

    //SteeringBehaviours
    List<SteeringBehaviour> SteeringBehaviours = new List<SteeringBehaviour>();

    // Use this for initialization
    void Start()
    {
        SteeringBehaviour[] steering = GetComponents<SteeringBehaviour>();
        for(int i = 0; i < steering.Length; i++)
        {
            SteeringBehaviours.Add(steering[i]);
        }
    }

    Vector3 seekTarget(Vector3 targetPos)
    {
        Vector3 desiredPos = targetPos - transform.position;
        desiredPos.Normalize();
        desiredPos *= flyingSpeed;
        return desiredPos - velocity;
    }

    Vector3 calculateForce()
    {
        Vector3 force = Vector3.zero;
        foreach(SteeringBehaviour behaviour in SteeringBehaviours)
        {
            if(behaviour.isActiveAndEnabled)
            {
                force += behaviour.calculateForce();
            }
        }
        return force;
    }

    // Update is called once per frame
    void Update()
    {
        force += calculateForce();

        Vector3 acceleration = force / mass;

        velocity += acceleration * Time.deltaTime;
        if (velocity.magnitude > 0.0001f)
        {
            transform.LookAt(transform.position + velocity);
        }
        transform.position += velocity * Time.deltaTime;
    }

}
