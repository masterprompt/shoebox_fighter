using UnityEngine;
using System.Collections;

public class SimpleSpawner : MonoBehaviour {
	public Enemy enemyPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnGUI(){
		if(GUI.Button(new Rect(0,0,100,20), "Spawn Enemy")){
			var enemy = GameObject.Instantiate(enemyPrefab, transform.position, transform.rotation) as Enemy;
		}
	}
}
