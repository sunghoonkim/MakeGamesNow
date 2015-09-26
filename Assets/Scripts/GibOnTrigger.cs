using UnityEngine;
using System.Collections;

public class GibOnTrigger : MonoBehaviour {

	public GameObject gib;


	void OnTriggerEnter(){

		Instantiate (gib, transform.position, Quaternion.identity);
		Destroy (gameObject);
	}



//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}
}
