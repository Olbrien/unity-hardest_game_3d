using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovementPlayer : MonoBehaviour
{
    public Rigidbody rigidBody;

    public float speed;

    public bool canTeleport = true;
    float timerTeleport;

    float horizontalAxis;
    float verticalAxis;

    [HideInInspector]
    public float horizontalAxisButton;
    [HideInInspector]
    public float verticalAxisButton;

    Vector3 movement;
    Vector3 movementButton;

    public LocalVariables localVariables;
    public VariableJoystick variableJoystickOneHorizontal;
    public VariableJoystick variableJoystickOneVertical;
    public VariableJoystick variableJoystickTwo;

    void FixedUpdate()
    {
        if (!canTeleport)
        {
            timerTeleport += Time.deltaTime;

            if (timerTeleport > 0.1f) { canTeleport = true; timerTeleport = 0; }
        }

        if (localVariables.joystickOne)
        {
            horizontalAxis = Mathf.Clamp(-variableJoystickOneHorizontal.Horizontal * 3, -1, 1);
            verticalAxis = Mathf.Clamp(-variableJoystickOneVertical.Vertical * 3, -1, 1);

            movement = new Vector3(horizontalAxis, 0, verticalAxis);
            movementButton = new Vector3(horizontalAxisButton, 0, verticalAxisButton);

            rigidBody.AddForce(movement * speed);
            rigidBody.AddForce(movementButton * speed);
            return;
        }

        if (localVariables.joystickTwo)
        {
            horizontalAxis = Mathf.Clamp(-variableJoystickTwo.Horizontal * 3, -1, 1);
            verticalAxis = Mathf.Clamp(-variableJoystickTwo.Vertical * 3, -1, 1);

            movement = new Vector3(horizontalAxis, 0, verticalAxis);
            movementButton = new Vector3(horizontalAxisButton, 0, verticalAxisButton);

            rigidBody.AddForce(movement * speed);
            rigidBody.AddForce(movementButton * speed);
            return;
        }


        horizontalAxis = -Input.GetAxis("Horizontal");
        verticalAxis = -Input.GetAxis("Vertical");

        movement = new Vector3(horizontalAxis, 0, verticalAxis);
        movementButton = new Vector3(horizontalAxisButton, 0, verticalAxisButton);

        rigidBody.AddForce(movement * speed);
        rigidBody.AddForce(movementButton * speed);
    }



    public void OnClickLeft()
    {
        horizontalAxisButton = +1;
    }
    public void OnReleaseLeft()
    {
        horizontalAxisButton = 0;
    }


    public void OnClickDown()
    {
        verticalAxisButton = +1;
    }
    public void OnReleaseDown()
    {
        verticalAxisButton = 0;
    }


    public void OnClickRight()
    {
        horizontalAxisButton = -1;
    }
    public void OnReleaseRight()
    {
        horizontalAxisButton = 0;
    }


    public void OnClickTop()
    {
        verticalAxisButton = -1;
    }
    public void OnReleaseTop()
    {
        verticalAxisButton = 0;
    }
}
