using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bgsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (bgs ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator bgs (){
		yield return new WaitForSeconds(6);
		SceneManager.LoadScene ("title");
	}
}

