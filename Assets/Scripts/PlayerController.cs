using UnityEngine;


public class PlayerController : MonoBehaviour
{

    //bodyRects[1]->setPosition(bodyRects[0]->getPosition().x + 250 * cos(angle[1]), bodyRects[0]->getPosition().y + 250 * sin(angle[1]));
    private float speed;
    private Vector3 pos;
    private Vector3 currPos;
    private Quaternion m_CharacterTargetRot;
    private Quaternion m_CameraTargetRot;
    private ParticleSystem emission;
    // Use this for initialization
    void Start()
    {
        speed = 0.5f;
        emission = GetComponentInChildren<ParticleSystem>();
        emission.Play();
        emission.Stop();
   //     emission.st
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 back = transform.TransformDirection(Vector3.back);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        
        pos = transform.position;
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += forward * speed;
          
            if (emission.isStopped)
               emission.Play();
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += back * speed;
            emission.Stop();
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down, 1.0f);
         //   transform.RotateAround(transform.localPosition, Vector3.down, 10.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, 1.0f);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(Vector3.left, 1.0f);
            //   transform.RotateAround(transform.localPosition, Vector3.down, 10.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(Vector3.right, 1.0f);
        }
    }

    void OnCollisionEnter(Collision col)
    {
    //    transform.position = pos;
    }
}
