using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour {

	public float speed;
	public float health;
	public CharacterController characterController;
	public static List<Character> characters = new List<Character>();
	public List<Transform> pawns;
	private Vector3 lookVector = Vector3.forward;
	public float turnSpeed = 2;

	// Use this for initialization
	void Start () {
	
	}
	public void OnEnable(){
		characters.Add(this);
	}
	public void OnDisable(){
		characters.Remove(this);
	}

	public void Move(Vector3 vector){
		characterController.SimpleMove(vector * speed);
	}
	
	// Update is called once per frame
	public virtual void Update () {

	}

	public virtual void FixedUpdate(){
		var velocity = characterController.velocity;
		if(velocity.x >0 ) lookVector = Vector3.forward;
		if(velocity.x <0) lookVector = Vector3.back;


		var targetRotation = Quaternion.LookRotation(lookVector, Vector3.up);
		foreach(var pawn in pawns){
			pawn.rotation = Quaternion.Slerp(pawn.rotation, targetRotation, Time.deltaTime * turnSpeed);
		}

	}
}
