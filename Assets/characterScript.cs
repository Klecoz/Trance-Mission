using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class characterScript : MonoBehaviour {

	public TextMeshProUGUI damageText;
    private Vector3 pushBack;
    public bool bossTime = false;

	public int health = 17;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
     
		if (health == 0) {
			SceneManager.LoadScene ("title");
		}
    
	}

	   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "badGuy"){
			health--;
			StartCoroutine(FadeTextToFullAlpha(1f, damageText));
             var opposite = -GetComponent<Rigidbody>().velocity;
             
             Debug.Log(opposite);
             GetComponent<Rigidbody>().AddForce(opposite * Time.deltaTime * 100000);
            //GetComponent<Rigidbody>().AddForce(force);
		}

        if (other.gameObject.tag == "bossWall"){
            if (!bossTime){
            other.GetComponent<AudioSource>().Stop();
            GameObject.FindGameObjectWithTag("bossMusic").GetComponent<AudioSource>().Play();
            bossTime = true;
            }
        }
	}

	 public IEnumerator FadeTextToFullAlpha(float t, TextMeshProUGUI i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
        }

		while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
    
    //This don't do nothin.
    public IEnumerator FadeTextToZeroAlpha(float t, TextMeshProUGUI i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}
