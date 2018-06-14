using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PromisedLand.Health { 

    public class Health : MonoBehaviour {

        public int maxHealth;
        public int currentHealth;

	    // Use this for initialization
	    public virtual void Start () {       
            currentHealth = maxHealth;
	    }

        void Update()
        {
            if (currentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }

        public void adjustHealth(int damage)
        {
            currentHealth += damage;
        }
    }
}