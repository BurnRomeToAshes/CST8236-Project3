using UnityEngine;
using System.Collections;

public class SunBehavior : MonoBehaviour{

    public float axialTilt;
    public float timeModifier;
    private Vector3 initialPos;
	// Use this for initialization
	void Start () {
        initialPos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, axialTilt*timeModifier);

        if (Input.GetKey(KeyCode.R))
        {
            if (timeModifier > 0.01)
                timeModifier -= 0.001f;
        }
        if (Input.GetKey(KeyCode.T))
        {
            timeModifier += 0.001f;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); // Bump player out;
    //   Vector3 back = transform.TransformDirection(Vector3.back);
 //       player.transform.localPosition += back * 10 * 0.5f;
    }



}
