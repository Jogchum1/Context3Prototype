using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentShipMovement : MonoBehaviour
{
    public float MoveSpeed = 5;
    public float RotationSpeed = 0.1f;
    private InputHandler Input;
    private NavMeshAgent Agent;

    private void Awake()
    {
        Input = GetComponent<InputHandler>();
        Agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        var moveTarget = new Vector3(Input.InputVector.x, 0, Input.InputVector.y);

        RotateTowardMovementTarget(moveTarget);

        Agent.Move(moveTarget * Time.deltaTime * MoveSpeed);
    }

    private void RotateTowardMovementTarget(Vector3 movementVector)
    {
        if (movementVector.magnitude == 0)
            return;
        var rotation = Quaternion.LookRotation(movementVector);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, RotationSpeed);
    }
}
