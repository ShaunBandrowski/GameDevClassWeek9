using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {

		if ( Input.GetKeyDown ( KeyCode.R ) ) {

			Application.LoadLevel ( Application.loadedLevel );

		}

	}
}
