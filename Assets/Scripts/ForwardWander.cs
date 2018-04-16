using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardWander : SteeringBehaviour
{
    public float noiseFrequencyVertical = 2f;
    public float amplitudeVertical = 2f;

    public float noiseFrequencyHorizontal = 10f;
    public float amplitudeHorizontal = 30f;

    public float radius = 10;
    public float distance = 15;

    float theta = 0.0f;
    float theta2 = 0.0f;

    Vector3 target;
    Vector3 worldTarget;

    // Use this for initialization
    void Start () {
		
	}

    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Vector3 c = transform.TransformPoint
                (Vector3.forward * distance);
            Gizmos.color = Color.gray;
            Gizmos.DrawLine(transform.position, worldTarget);
            Gizmos.DrawWireSphere(c, radius);
            Gizmos.DrawWireSphere(worldTarget, 1);
        }
    }

    public static float mapFunction(float value, float range1, float range2, float mapRange1, float mapRange2)
    {
        float difference = value - range1;
        float rangeDiff = range2 - range1;
        float mapRangeDiff = mapRange2 - mapRange1 ;
        return mapRange1 + ((difference / rangeDiff) * mapRangeDiff);
    }
	
	public override Vector3 calculateTarget()
    {
        //Maping the returned Value to between -1 and 1
        float noiseValueHorizon = mapFunction(Mathf.PerlinNoise(theta, 0), 0, 1, 1, -1);
        Debug.Log(noiseValueHorizon);

        float viewAngleHorizon = noiseValueHorizon * amplitudeHorizontal * Mathf.Deg2Rad;

        Vector3 objectAngles = transform.rotation.eulerAngles;
        objectAngles.x = 0;

        target.x = Mathf.Sin(viewAngleHorizon);
        target.z = Mathf.Cos(viewAngleHorizon);
        target.y = 0;
        objectAngles.z = 0;

        target *= radius;

        Vector3 localTarget = target + (Vector3.forward * distance);

        worldTarget = transform.position + Quaternion.Euler(objectAngles) * localTarget;
        theta += Time.deltaTime * Mathf.PI * 2.0f * noiseFrequencyHorizontal * 0.01f;
        return fighterPlane.seekTarget(worldTarget);
    }
}
