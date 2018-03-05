using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringBehaviours : MonoBehaviour {

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

    // Use this for initialization
    void Start () {
	}

    // Update is called once per frame
    void Update() {
        if (!wonder)
        {
            force = chaseBehaviour(target.transform.position);
        }
        else
        {
            force = chaseBehaviour(generateNewTarget());
        }
        
        Vector3 acceleration = force / mass;

        velocity += acceleration * Time.deltaTime;
        if (velocity.magnitude > 0.0001f)
        {
            transform.LookAt(transform.position + velocity);
        }
        transform.position += velocity * Time.deltaTime;
    }

    Vector3 chaseBehaviour(Vector3 targetPos)
    {
        Vector3 desiredPos = targetPos - transform.position;
        desiredPos.Normalize();
        desiredPos *= flyingSpeed;
        return desiredPos - velocity;
    }

    Vector3 generateNewTarget()
    {
        if((wonderTarget-transform.position).magnitude < 10 || wonderTarget == Vector3.zero)
        {
            wonderTarget = new Vector3(Random.Range(transform.position.x - 100, transform.position.x + 100), Random.Range(minAltitude,maxAltitude) , Random.Range(transform.position.y - 100, transform.position.y + 100));
        }

        return wonderTarget;
    }
}
