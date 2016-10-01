using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	// PRIVATE INSTANCE VARIABLES ++++++++++++++++++

	// PUBLIC INSTANCE VARIABLES (TESTING) +++++++++
	public int cloudNumber = 3;
	public GameObject cloud;

	// PUBLIC PROPERTIES +++++++++++++++++++++++++++


	// Use this for initialization
	void Start () {
		for (int cloudCount = 0; cloudCount < this.cloudNumber; cloudCount++) {
			Instantiate (this.cloud);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
