using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewPew : MonoBehaviour {
	public GameObject soylentIsPeople;
	public GameObject crystalBallRave;
	public GameObject swingerPewPew;
	public GameObject doomSpiral;

	public GameObject playerObject;
	public bool pew1;
	public bool pew2;
	public bool pew3;
	public bool pew4;
	public bool pew5;


	private bool runOnce = false;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (playerObject.GetComponent<characterScript> ().bossTime == true) {
			if (!runOnce) {
				runOnce = true;
				runFirst();
			}
		}
			

	}


	public IEnumerator nextPhase() {

		yield return new WaitForSeconds(7);
		CancelInvoke();
		if (pew1){
		InvokeRepeating("crystalBallRaveFun", 100f * Time.deltaTime, 130f * Time.deltaTime);
		}
		if (pew2){
		InvokeRepeating("crystalBallRaveFun", 5f * Time.deltaTime, 200f * Time.deltaTime);
		}
		if (pew3){
		InvokeRepeating("crystalBallRaveFun", 100f * Time.deltaTime, 130f * Time.deltaTime);
		}
		if (pew4){
		InvokeRepeating("crystalBallRaveFun", 5f * Time.deltaTime, 200f * Time.deltaTime);
		}
		if (pew5){
		InvokeRepeating("crystalBallRaveFun", 100f * Time.deltaTime, 130f * Time.deltaTime);
		}
		yield return new WaitForSeconds(10);
		CancelInvoke();

		if (pew1){
			InvokeRepeating("swingSpawn", 100f * Time.deltaTime, 150f * Time.deltaTime);
		}
		if (pew2){
			InvokeRepeating("swingSpawn", 20f * Time.deltaTime, 200f * Time.deltaTime);
		}
		if (pew3){
			InvokeRepeating("swingSpawn", 70f * Time.deltaTime, 150f * Time.deltaTime);
		}
		if (pew4){
			InvokeRepeating("swingSpawn", 5f * Time.deltaTime, 200f * Time.deltaTime);
		}
		if (pew5){
			InvokeRepeating("swingSpawn", 140f * Time.deltaTime, 150f * Time.deltaTime);
		}
		yield return new WaitForSeconds(10);
		CancelInvoke();

		if (pew1){
			InvokeRepeating("sprSpawn", 5f * Time.deltaTime, 50f * Time.deltaTime);
		}
		if (pew2){
			InvokeRepeating("sprSpawn", 5f * Time.deltaTime, 50f * Time.deltaTime);
		}
		if (pew3){
			InvokeRepeating("sprSpawn", 5f * Time.deltaTime, 250f * Time.deltaTime);
		}
		if (pew4){
			InvokeRepeating("sprSpawn", 5f * Time.deltaTime, 50f * Time.deltaTime);
		}
		if (pew5){
			InvokeRepeating("sprSpawn", 5f * Time.deltaTime, 50f * Time.deltaTime);
		}
		yield return new WaitForSeconds(10);
		CancelInvoke();



	}

	void runFirst() {
		if (pew1){
			InvokeRepeating("pewpewOne", 5f * Time.deltaTime, 45f * Time.deltaTime);
		}
		if (pew2){
			InvokeRepeating("pewpewOne", 5f * Time.deltaTime, 60f * Time.deltaTime);
		}
		if (pew3){
			InvokeRepeating("pewpewOne", 5f * Time.deltaTime, 75f * Time.deltaTime);
		}
		if (pew4){
			InvokeRepeating("pewpewOne", 5f * Time.deltaTime, 90f * Time.deltaTime);
		}
		if (pew5){
			InvokeRepeating("pewpewOne", 5f * Time.deltaTime, 105f * Time.deltaTime);
		}
		StartCoroutine(nextPhase());

	}

	void pewpewOne() {
		Instantiate(soylentIsPeople, transform.position, soylentIsPeople.transform.rotation);
	}

	void crystalBallRaveFun() {
		Instantiate(crystalBallRave, transform.position, crystalBallRave.transform.rotation);
	}

	void swingSpawn() {
		Instantiate(swingerPewPew, transform.position, crystalBallRave.transform.rotation);
	}

	void sprSpawn() {
		Instantiate(doomSpiral, transform.position, crystalBallRave.transform.rotation);
	}




}
