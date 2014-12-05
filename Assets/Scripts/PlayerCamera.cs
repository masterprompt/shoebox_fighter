using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {

	public Transform target;
	public float smoothTime = 0.3F;
	public Vector3 velocity = Vector3.zero;
	public Vector3 offset;
	public Vector3 targetPosition;
	// Use this for initialization
	void Start () {
		offset = target.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(Character.characters.Count ==0) return;
		var center = Vector3.zero;
		foreach(var character in Character.characters){
			center += character.transform.position;
		}
		center /= Character.characters.Count;

		targetPosition = center - offset;
		transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
	}
}
