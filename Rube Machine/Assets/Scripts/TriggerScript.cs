using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter (Collider activator){

		Debug.Log (activator.name + " entered this trigger");

		Destroy (activator.gameObject);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
