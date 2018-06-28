using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour {

	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D (Collision2D col ) {
		Application.LoadLevel (Application.loadedLevel);

	}


}
