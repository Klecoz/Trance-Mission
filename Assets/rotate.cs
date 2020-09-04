using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

	public bool clockwise;
	public bool counterclockwise;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (clockwise){
		transform.Rotate(Vector3.up * Time.deltaTime * 100);
		}

		if (counterclockwise){
		transform.Rotate(Vector3.down * Time.deltaTime * 70);
		}
	}
}
