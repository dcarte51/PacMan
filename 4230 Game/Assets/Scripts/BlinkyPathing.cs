using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkyPathing : MonoBehaviour {
    public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = target.position;
	}
}
