using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightFade : MonoBehaviour {

	private Light onOff;
	void Start () {
		onOff = GetComponent<Light>();
	
	}
	
	// Update is called once per frame
	void Update () {
		 if ( Random.value > 0.97 ) //a random chance
        {
           if ( onOff.enabled == true ) //if the light is on...
           {
             onOff.enabled = false; //turn it off
           }
           else
           {
             onOff.enabled = true; //turn it on
           }
        }
	}


}
