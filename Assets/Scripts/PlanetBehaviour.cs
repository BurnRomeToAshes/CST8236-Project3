using UnityEngine;
using System.Collections;

public class PlanetBehaviour : MonoBehaviour {

    public float axialTilt;
    public float timeModifier;
    public Vector3 sunPos;
    public float planetModifier; // For earth this one is 1, Mars is 1.881 and so on
    // Use this for initialization
    void Start()
    {
        GameObject sun = GameObject.FindGameObjectWithTag("Sun");
        sunPos = sun.transform.position;
    }
    // radians = degrees * pi / 180
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.up * axialTilt * Time.deltaTime);

       transform.RotateAround(sunPos, Vector3.up, 100 * 6 * Time.deltaTime * timeModifier / planetModifier); // 100 * 6 * Time.deltatime - 60 it's 60 seconds for a full Earth rotation around sun

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
}
