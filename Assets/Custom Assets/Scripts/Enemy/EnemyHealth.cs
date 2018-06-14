using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PromisedLand.Health;

public class EnemyHealth : Health {

    public bool disappearOnDeath;

	// Use this for initialization
	public override void Start () {
        base.Start();
	}
	
	// Update is called once per frame
	void Update () {
	    if(currentHealth < maxHealth)
        {
            if (disappearOnDeath)
                Destroy(gameObject);
        }
	}
}
