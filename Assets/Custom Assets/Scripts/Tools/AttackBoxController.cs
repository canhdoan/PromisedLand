using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBoxController : MonoBehaviour {
    public float timer, beginTime, endTime;
    private bool doAttack;
    private BoxCollider myCollider;
	// Use this for initialization
	void Start () {
        myCollider = gameObject.GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
        if (doAttack) 
            timer += Time.deltaTime;
        
        if (timer > beginTime && !myCollider.enabled)
            myCollider.enabled = true;

        if (timer > endTime)
        {
            myCollider.enabled = false;
            doAttack = false;
            timer = 0;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Enemy"))
        {
            other.gameObject.GetComponentInParent<EnemyHealth>().adjustHealth(-10);
        }   
    }

    public void activate()
    {
        doAttack = true;
    }
}
