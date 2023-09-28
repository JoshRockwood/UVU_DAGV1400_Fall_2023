// Player Controller (Movement and Jump)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float jumpForce = 10.0f;
    [SerializeField] private float gravity = -9.81f;

    private CharacterController controller;
    private Vector3 moveDirection;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }
// Jump
    private void Update()
    {
        if (controller.isGrounded)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            moveDirection = transform.TransformDirection(new Vector3(horizontalInput, 0, verticalInput));
            moveDirection *= moveSpeed;

            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpForce;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
