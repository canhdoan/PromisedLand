using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PromisedLand.Health;

public class PlayerHealth : Health {

	// Use this for initialization
	public override void Start () {
        base.Start();
	}

    // Update is called once per frame
    void Update()
    {
        if (currentHealth < 0)
        {
            //Gonna teleport to reset point on death
        }
    }
}
