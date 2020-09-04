using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x - 4f * Time.deltaTime, transform.position.y, transform.position.z);
		transform.Rotate(Vector3.right * Time.deltaTime * 90);
	}
}
