using UnityEngine;
using System.Collections;
using System.Linq;

public class Enemy : Character {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update();
		var player = Character.characters.OfType<Player>().FirstOrDefault();
		if(player==null) return;
		var vector = player.transform.position - transform.position;
		vector.y = 0;
		Move(vector.normalized);
	}
}
