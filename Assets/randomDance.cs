using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomDance : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var dancer = GetComponent<Puppet.Dancer>();

        dancer.footDistance *= Random.Range(0.8f, 2.0f);
        dancer.stepFrequency *= Random.Range(0.4f, 1.6f);
        dancer.stepHeight *= Random.Range(0.75f, 1.25f);
        dancer.stepAngle *= Random.Range(0.75f, 1.25f);

        dancer.hipHeight *= Random.Range(0.75f, 1.25f);
        dancer.hipPositionNoise *= Random.Range(0.75f, 1.25f);
        dancer.hipRotationNoise *= Random.Range(0.75f, 1.25f);

        dancer.spineBend = Random.Range(4.0f, -16.0f);
        dancer.spineRotationNoise *= Random.Range(0.75f, 1.25f);

        dancer.handPositionNoise *= Random.Range(0.5f, 2.0f);
        dancer.handPosition += Random.insideUnitSphere * 0.25f;

        dancer.headMove *= Random.Range(0.2f, 2.8f);
        dancer.noiseFrequency *= Random.Range(0.4f, 1.8f);
        dancer.randomSeed = Random.Range(0, 0xffffff);

        var renderer = dancer.GetComponentInChildren<Renderer>();
        renderer.material.color = Random.ColorHSV(0, 1, 0.6f, 0.8f, 0.8f, 1.0f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
