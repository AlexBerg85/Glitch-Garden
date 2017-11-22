using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject obj = collider.gameObject;
        // Leave the method if not colliding with defender
        if (!obj.GetComponent<Defender>())
        {
            return;
        }
        Debug.Log("Lizard collided with " + collider);
    }
}
