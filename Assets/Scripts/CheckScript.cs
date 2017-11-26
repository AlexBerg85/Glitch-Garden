using UnityEngine;
using System.Collections;

public class CheckScript : MonoBehaviour {

	private float difficulty;

	// Use this for initialization
	void Start () {
		difficulty = PlayerPrefsManager.GetDifficulty ();
		Debug.Log (difficulty);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
