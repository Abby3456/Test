using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour {

	public Transform lookOverride;
	public Transform moveOverride;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider activator){

		Debug.Log(this.name + " got triggered by " + activator.name);

		CameraControl camControl = Camera.main.GetComponent<CameraControl>();

		if (lookOverride != null) {
			camControl.lookAtTarget = lookOverride;	
			Destroy (this.gameObject);
		}

		if (moveOverride != null) {
			camControl.moveToTarget = moveOverride;
			Destroy (this.gameObject);
		}
	}

	void OnDrawGizmos(){

		if (lookOverride != null) {
			Gizmos.color = Color.cyan;
			Gizmos.DrawLine (transform.position, lookOverride.position);
		}
			
		if (moveOverride != null) {
			Gizmos.color = Color.magenta;
			Gizmos.DrawLine (transform.position, moveOverride.position);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
