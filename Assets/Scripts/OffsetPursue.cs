using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetPursue : SteeringBehaviour
{

    public GameObject leader;
    private BaseSteering leaderScript;
    private Vector3 offset;
    Vector3 worldtarget;

    // Use this for initialization
    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Gizmos.color = Color.grey;
            Gizmos.DrawLine(transform.position, worldtarget);
        }
    }


    void Start()
    {
        leaderScript = leader.GetComponent<BaseSteering>();
        offset = transform.position - leaderScript.transform.position;
        offset = Quaternion.Inverse(leaderScript.transform.rotation) * offset;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override Vector3 calculateTarget()
    {
        worldtarget = leaderScript.transform.TransformPoint(offset);
        float dist = Vector3.Distance(worldtarget
            , transform.position);
        float time = dist / leaderScript.maxSpeed;

        Vector3 targetPos = worldtarget + (leaderScript.velocity * time);
        return fighterPlane.seekTarget(targetPos);

    }
}
