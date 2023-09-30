using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 5.0f;
    [SerializeField] private float crouchSpeed = 2.5f;
     private float currentSpeed = 5.0f;
    [SerializeField] private float jumpForce = 8.0f;
    [SerializeField] private float gravity = -9.81f;
    private bool isCrouching = false;

    private CharacterController controller;
    private Vector3 moveDirection;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (controller.isGrounded)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            moveDirection = transform.TransformDirection(new Vector3(horizontalInput, 0, verticalInput));
            moveDirection *= currentSpeed;

            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpForce;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.C))
        {
            ToggleCrouch();
        }

        UpdateSize();
    }

    private void ToggleCrouch()
    {
        isCrouching = !isCrouching;

        if (isCrouching)
        {
            currentSpeed = crouchSpeed;
        }
        else
        {
            currentSpeed = walkSpeed;
        }

    }

    private void UpdateSize()
    {   
        if (isCrouching)
        {
            transform.localScale = new Vector3 (3.192f, 1.5f, 3.192f);
        }
        else
        {
            transform.localScale = new Vector3 (3.192f, 3.192f, 3.192f);
        }
    }
}