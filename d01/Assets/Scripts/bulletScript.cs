using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

	public GameObject limit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3(0,-5,0) * Time.deltaTime);
		if (transform.position.y <= limit.transform.position.y)
			GameObject.Destroy (gameObject);
	}
}
