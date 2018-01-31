using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHammer : MonoBehaviour {


	public GameObject Player;
	public Sprite firstImage;
	public Sprite secondImage;

	private SpriteRenderer sRend;
	private Rigidbody2D rBody;

	// initiaisation

	void Start()
	{
		// Player.velocity = new Vector2 (5, 0);
		rBody = Player.GetComponent<Rigidbody2D> ();
		sRend = Player.GetComponent<SpriteRenderer> ();
		 rBody.velocity = new Vector2 (3, 0);


	}

	void Update()
	{


	}

	void OnMouseDown () {
		// GameObject gObject = GameObject.Find ("Player");
		if (sRend.sprite = firstImage) {
			
			sRend.sprite = secondImage;
		}
		else 
		{
			sRend.sprite = firstImage;
		}




		// Debug.Log (gObject.name);
	}
}
