using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class npcController : MonoBehaviour {

	public bool isDJEggs;
	public AnimationCurve myCurve;
	public bool isSpinNPC;
	public bool isSpinNPCtheOtherWay;
	public bool craySpinNPC;
	public bool isWalkerHorizontal;
	public bool bossBattleSpin;
	float myRange;
	float myRangeForJump;
	// Use this for initialization
	void Start () {
		myRange = Random.Range(1, 30);
		myRangeForJump = Random.Range(1.1f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (isSpinNPC) {
		transform.Rotate(Vector3.up * Time.deltaTime * 50 * myRange);
		if (myRange < 15){
			transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length))* myRangeForJump, transform.position.z);
		}
		}

		if (bossBattleSpin){
			transform.Rotate(Vector3.up * Time.deltaTime * 300);
			transform.position = new Vector3(transform.position.x - 4f * Time.deltaTime, transform.position.y, transform.position.z);
		}

		if (isSpinNPCtheOtherWay) {
		transform.Rotate(Vector3.down * Time.deltaTime * 50 * myRange);
		if (myRange > 15){
			transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)) * myRangeForJump, transform.position.z);
		}
		}

		if (craySpinNPC) {
		transform.Rotate(Vector3.right * Time.deltaTime * 50 * myRange);
		}

		if (isDJEggs){
			
		}

	}
}
