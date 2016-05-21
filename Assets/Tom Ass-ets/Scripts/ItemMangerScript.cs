using UnityEngine;
using System.Collections;

public class ItemMangerScript : MonoBehaviour {
	public float TotWeight;
	public int TotItems;
	public float TotPrice;
	// Use this for initialization
	void Start() {
	
	}
	
	// Update is called once per frame
	void Update () {
		//To display total items in console:
		//Debug.Log ("Total items " + TotItems);
	}
	void addPickUp(float[] farr){
		TotItems += 1;
		TotPrice += farr [0];
		TotWeight += farr [1];
	}
}
