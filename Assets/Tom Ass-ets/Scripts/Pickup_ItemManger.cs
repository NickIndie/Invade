using UnityEngine;
using System.Collections;

public class Pickup_ItemManger : MonoBehaviour {
	public GameObject manager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
//	void OnTriggerEnter(Collider col) {
//
//		//if the other collider is 'player'
//		if (col.gameObject.tag == "Player") {
//			//tells the manager gameObj to add a pickup
//			manager.SendMessage ("addPickUp");
//			//destroys this gameObj
//			Destroy (this.gameObject);
//		}
//	}

	void Player_Interact(){
		//tells the manager gameObj to add a pickup
		manager.SendMessage ("addPickUp");
		//destroys this gameObj
		Destroy (this.gameObject);
	}
}
