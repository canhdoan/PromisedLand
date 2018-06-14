using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldObject : MonoBehaviour {
    public GameObject myHand;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = myHand.transform.position;
        gameObject.transform.rotation = myHand.transform.rotation;
	}
}
