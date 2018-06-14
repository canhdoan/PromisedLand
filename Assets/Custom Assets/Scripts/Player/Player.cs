using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;


public class Player : ThirdPersonCharacter{

    public GameObject[] attacks;
    [Range(0, 3)] public int attackCount = 0; 

	// Use this for initialization
	public override void Start () {
        base.Start();
        attacks = GameObject.FindGameObjectsWithTag("PlayerAttack");
	}
	
	public void Attack()
    {
        gameObject.GetComponentInParent<Animator>().Play("Attack" + attackCount);
        AttackBoxController abc = attacks[attackCount].GetComponent<AttackBoxController>();
        abc.activate();
        attackCount++;
    }

    void FixedUpdate()
    {
        //I'll add a timer to this later
        if (attackCount > 3)
        {
            attackCount = 0;
        }

    }
}
