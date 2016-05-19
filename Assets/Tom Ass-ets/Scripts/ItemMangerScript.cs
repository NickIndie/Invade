using UnityEngine;
using System.Collections;

public class ItemMangerScript : MonoBehaviour {
	public int TotWeight;
	public int TotItems;
	public int TotPrice;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//To display total items in console:
		//Debug.Log ("Total items " + TotItems);
	}
	void addPickUp(){
		TotItems += 1;
	}
}
