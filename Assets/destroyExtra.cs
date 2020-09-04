using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyExtra : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "badGuy"){
			Debug.Log("I am hitting a boss dude object.");
			Destroy(other.gameObject);
		}
	}
}
