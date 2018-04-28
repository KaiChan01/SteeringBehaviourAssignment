using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSteering : MonoBehaviour
{
    public int maxAltitude;
    public int minAltitude;
    public int maxSpeed;
    public float mass;

    [HideInInspector]
    public Vector3 force = Vector3.zero;
    [HideInInspector]
    public Vector3 velocity = Vector3.zero;
    [HideInInspector]
    public Vector3 acceleration = Vector3.zero;

    // float fallingAcc = 9.81f;
    // float orientation;

    //SteeringBehaviours
    List<SteeringBehaviour> SteeringBehaviours = new List<SteeringBehaviour>();

    void Start()
    {
        SteeringBehaviour[] steering = GetComponents<SteeringBehaviour>();
        for(int i = 0; i < steering.Length; i++)
        {
            this.SteeringBehaviours.Add(steering[i]);
        }
    }

    float checkOrientation()
    {
        float orientation = Vector3.Dot(transform.forward, Vector3.up);
        return orientation;
    }

    public Vector3 seekTarget(Vector3 targetPos)
    {
        Vector3 desiredPos = targetPos - transform.position;
        desiredPos.Normalize();
        desiredPos *= maxSpeed;
        return desiredPos - velocity;
    }

    Vector3 calculateForce()
    {
        Vector3 force = Vector3.zero;
        foreach(SteeringBehaviour behaviour in SteeringBehaviours)
        {
            if(behaviour.isActiveAndEnabled)
            {
                force += behaviour.calculateTarget() * behaviour.weight;
            }
        }

        return force;
    }

    // Update is called once per frame
    void Update()
    {
        //orientation = checkOrientation();

        force = calculateForce();

        acceleration = force / mass;

        /*
        if (orientation > 0)
        {
            //Ship is facing up
            acceleration = acceleration - (acceleration * orientation);
        }
        else
        {
            //Ship is facing down
            acceleration *= 1 + Mathf.Abs(orientation);
        }
        */
        

        velocity += acceleration * Time.deltaTime;

        Vector3 globalUp = new Vector3(0, 0.2f, 0);
        Vector3 accelUp = acceleration * 0.05f;
        Vector3 bankUp = accelUp + globalUp;        
        Vector3 tempUp = transform.up;
        tempUp = Vector3.Lerp(tempUp, bankUp, Time.deltaTime);

        if (velocity.magnitude > 0.0001f)
        {
            transform.LookAt(transform.position + velocity, tempUp);
            transform.position += velocity * Time.deltaTime;
        }
    }

}
