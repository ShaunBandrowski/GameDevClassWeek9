using UnityEngine;
using System.Collections;

public class GridInstantiate : MonoBehaviour {


	public GameObject pathInstantiatePrefab;

	public GameObject prefabOne;
	public GameObject prefabTwo;

	int roomLength = 0;
	int roomWidth = 0;


	
	// Use this for initialization
	void Start () {

		roomLength = Random.Range(2,7);
		roomWidth = Random.Range(2,7);


		for ( int x = 0; x < roomLength; x+=1){

			for ( int z = 0; z < roomWidth; z+=1){

				Vector3 pos = new Vector3 (x*5,0,z*5) + transform.position;	

				float n = Random.Range(0f,1f);

				if (n < 0.25f) {
					Instantiate (prefabOne,pos,Quaternion.Euler ( 0f, 0f, 0f ));

				}
				else if (n >= 0.25f && n <= 0.95f){

					Instantiate (prefabTwo,pos,Quaternion.Euler ( 0f, 0f, 0f ));

				}

				float a = Random.Range(0f,1f);
				
				if (a <= 0.007f){

					Instantiate(pathInstantiatePrefab, transform.position, Quaternion.identity);

				}

			}
		
		}
	}
	
	// Update is called once per frame
	void Update () {

		
	}
}
