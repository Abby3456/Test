using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextStart : MonoBehaviour {

	public Text screenText;

	// Use this for initialization
	void Start () {

		//screenText = GetComponent<Text>;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.Space)) {

			screenText.text = " ";

		}
		
	}

	void OnTriggerEnter(Collider winCollision){

		if (winCollision.gameObject.tag == "Win") {

			screenText.text = "Yay!";

		}
	}
}
