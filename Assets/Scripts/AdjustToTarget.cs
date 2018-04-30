using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustToTarget : SteeringBehaviour
{
    public int lockOnInterval;
    public int lockDuration;
    public GameObject target;
    private bool seekToggle;
    private float elapsed;
    Vector3 worldTarget = Vector3.zero;

    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, worldTarget);
        }
    }

    // Use this for initialization
    void Start()
    {
        seekToggle = true;
    }

    public override Vector3 calculateTarget()
    {
        elapsed += Time.deltaTime;
        if (seekToggle)
        {
            if(elapsed < lockDuration)
            {
                worldTarget = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
                return fighterPlane.seekTarget(worldTarget);
            }
            else
            {
                seekToggle = false;
                elapsed = 0;
            }
        }
        else
        {
            if(elapsed > lockOnInterval)
            {
                seekToggle = true;
                elapsed = 0;
            }
        }

        return Vector3.zero;
    }
}
