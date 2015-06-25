using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AccelleratedMoving : MonoBehaviour {

	public int speedFactor = 20;
	// Update is called once per frame
	void Update () 
	{

		var gtext = GameObject.Find ("statusText");
		var text = gtext.GetComponent<Text> ();
		text.text = Input.acceleration.x + "x" + Input.acceleration.y + "x" + Input.acceleration.z;

		transform.Translate(Input.acceleration.x/speedFactor, 0, -(Input.acceleration.z/speedFactor));


	}
}
