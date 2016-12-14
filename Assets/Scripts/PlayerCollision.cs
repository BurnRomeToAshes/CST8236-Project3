using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {


    private Vector3 pos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        pos = transform.position;
	}

    void OnCollisionEnter(Collision col)
    {
    //    GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

}
