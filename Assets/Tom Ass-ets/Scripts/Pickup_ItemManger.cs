using UnityEngine;
using System.Collections;

public class Pickup_ItemManger : MonoBehaviour {
	public GameObject manager;
	private float[] ObjInfo;
	public float Value;
	public float Weight;
	// Use this for initialization
	void Start () {
		ObjInfo = new float[2];
		ObjInfo [0] = Value;  //$$ Value
		ObjInfo [1] = Weight;  // weight
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
		manager.SendMessage ("addPickUp", ObjInfo);
		//destroys this gameObj
		Destroy (this.gameObject);
	}
}
