using UnityEngine;
using System.Collections;

public class PathInstantiate : MonoBehaviour {

	public GameObject gridInstantiatePrefab;
	public Transform prefab;
	int counter = 0;

	int floorTileCount = 0;

	float floorTileRotateOne = 0f;

	float floorTileRotateTwo = 0f;

	Collider thingCurrentlyInside;

	// Use this for initialization
	void Start () {

		floorTileCount = Random.Range(40,70);

		if (Random.value<.8f){
			floorTileRotateOne = 90f;
		}else{
			floorTileRotateOne = 0f;
		}

		if (Random.value<.8f){
			floorTileRotateTwo = -90f;
		}else{
			floorTileRotateTwo = 0f;
		}
		// floorTileRotateOne = Random.Range(45f,90f);

		// floorTileRotateTwo = Random.Range(-90f,-45f);

	}
	
	// Update is called once per frame
	void Update () {

		if (counter < floorTileCount){

			Instantiate(prefab);

			float number = Random.Range(0f,1f);
		
			if (number < 0.25f) {

				transform.Rotate ( 0f, floorTileRotateOne, 0f ); 

			}else if (number < 0.5f){

				transform.Rotate ( 0f, floorTileRotateTwo, 0f ); 

			}

			float a = Random.Range(0f,1f);

			if (a <= 0.01f){

				Instantiate(gridInstantiatePrefab, transform.position, Quaternion.identity);

			}
			Instantiate (prefab, transform.position, Quaternion.identity);


			transform.position += transform.forward *5f;

			counter+=1;

		}
		else{
			Destroy(gameObject);
		}

		if ( thingCurrentlyInside != null ) {
			// then damage it.
			Destroy(thingCurrentlyInside);
		}



	}

	void OnTriggerEnter ( Collider activator ) {
		thingCurrentlyInside = activator; // want to remember the thing that entered the trigger
	}
	
	void OnTriggerExit ( Collider exiter ) {
		// "null" means nothing, empty, absence of anything
		thingCurrentlyInside = null;
	}
}
