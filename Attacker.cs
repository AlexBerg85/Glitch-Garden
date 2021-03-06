﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

  
    private float currentSpeed;
    private GameObject currentTarget;


	// Use this for initialization
	void Start () {
        

		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}

    void OnTriggerEnter2D()
    {
        Debug.Log(name + " trigger enter");
    }

    public void SetSpeed (float speed)
    {
        currentSpeed = speed;
    }

    public void StrikeCurrentTarget (float damage)
    {
        Debug.Log(name + " gave damage" +damage);
    }

    public void Attack (GameObject obj)
    {
        currentTarget = obj;
    }
}
