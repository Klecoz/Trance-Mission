using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ggjScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (ggj ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator ggj (){
		yield return new WaitForSeconds(3);
		gameObject.SetActive (false);
	}
}
