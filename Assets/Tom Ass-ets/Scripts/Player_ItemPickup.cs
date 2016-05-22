using UnityEngine;
using System.Collections;

public class Player_ItemPickup : MonoBehaviour {
	public GameObject manager;
	public GameObject cam;
	private Vector3 fwd;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("e")) {
			fwd = cam.transform.forward;
			RaycastHit hit;
			if (Physics.Raycast (transform.position, transform.forward, out hit, 3f)) {
				GameObject other = hit.collider.gameObject;

				if (other.tag == "Pickup") {
					other.SendMessage ("Player_Interact");
				}
			}
		}
	
	}
	void FixedUpdate(){

	}

		
}
