using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    public Rigidbody rigidBody;
    public Camera playerCamera;
    public float speed;
    public AudioSource footstep;

    private Vector3 previousPosition;
    private float pathLengthFootstep;

    // Use this for initialization
    void Start()
    {
        pathLengthFootstep = 0;
        previousPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(speed * GetMovementVector(transform.forward));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(speed * GetMovementVector(transform.forward * -1));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(speed * GetMovementVector(transform.right * -1));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * GetMovementVector(transform.right));
        }

        pathLengthFootstep += (transform.position - previousPosition).magnitude;
        previousPosition = transform.position;

        if (pathLengthFootstep >= 2)
        {
            footstep.Play();
            pathLengthFootstep = 0;
        }

        transform.rotation = playerCamera.transform.rotation;
    }
    Vector3 GetMovementVector(Vector3 direction)
    {
        return Vector3.ProjectOnPlane(direction, new Vector3(0, 1, 0)).normalized;
    }
}
