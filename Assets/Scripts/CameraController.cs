using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    GameObject player;
     
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {

       

        if (Input.GetKey(KeyCode.Q))
        {
            if (Camera.main.fieldOfView > 50)
              Camera.main.fieldOfView -= 0.5f;
        }
        if (Input.GetKey(KeyCode.E))
        {
            if (Camera.main.fieldOfView < 80)
                Camera.main.fieldOfView += 0.5f;
        }

       

    }
}
