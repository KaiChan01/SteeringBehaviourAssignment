using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * This script is used to rotate the imported skybox to give it a more dynamic feel and look
 * Code referenced from https://www.youtube.com/watch?v=cqGq__JjhMM
 */
public class RotateSky : MonoBehaviour {

    public float rotationSpeed;
	// Update is called once per frame

	void FixedUpdate () {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
	}
}
