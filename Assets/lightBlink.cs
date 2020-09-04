using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightBlink : MonoBehaviour {

	private Light onOffBlink;
	void Start () {
		onOffBlink = GetComponent<Light>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Random.value > 0.3 ) //a random chance
        {
           if ( onOffBlink.enabled == true ) //if the light is on...
           {
             onOffBlink.enabled = false; //turn it off
           }
           else
           {
             onOffBlink.enabled = true; //turn it on
           }
        }
	
}
}
