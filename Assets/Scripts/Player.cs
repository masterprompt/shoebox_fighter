using UnityEngine;
using System.Collections;

public class Player : Character {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update();

		var vector = Vector3.zero;

		if(Input.GetKey(KeyCode.A)) vector.x = -1;
		if(Input.GetKey(KeyCode.D)) vector.x = 1;
		if(Input.GetKey(KeyCode.W)) vector.z = 1;
		if(Input.GetKey(KeyCode.S)) vector.z = -1;
		Move(vector);

	}
}
