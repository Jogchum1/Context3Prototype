using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float MoveSpeed = 5;
    public float RotationSpeed = 0.1f;


    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MoveShip();
    }

    public void MoveShip()
    {
        float hor = Input.GetAxis("Horizontal");
        float xPos = MoveSpeed * hor;

        float ver = Input.GetAxis("Vertical");
        float rotation = RotationSpeed * ver;


        Vector3 CurrentAngle = transform.localEulerAngles;
        transform.localEulerAngles = new Vector3(CurrentAngle.x, CurrentAngle.y + rotation, CurrentAngle.z);

        transform.Translate(Vector3.left * xPos* MoveSpeed);
    }
}
