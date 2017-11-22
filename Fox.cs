using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Attacker))]
public class Fox : MonoBehaviour {

    private Animator anim;
    private Attacker attacker;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        attacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collider)
    {
        

        GameObject obj = collider.gameObject;
        // Leave the method if not colliding with defender
        if (!obj.GetComponent<Defender>())
        {
            return;
        }

        if (obj.GetComponent<Stone>())
        {
            Debug.Log("Fox collided with" + collider);
            anim.SetTrigger("Jump trigger");
        } else
        {
            anim.SetBool("isAttacking", true);
            attacker.Attack(obj);
        }
            Debug.Log("Fox collided with" + collider);
    }
}
