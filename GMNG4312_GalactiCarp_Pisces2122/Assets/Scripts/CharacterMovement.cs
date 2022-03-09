using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    
   
    public float speed = 6f;
    public float gravity = -9.81f;
    public float jumpHeight = 3.0f;

    Vector3 velocity;
    bool isGrounded;
    //Private Variables for Jumping
   // private float verticalVelocity;
   // private float gravity = 14.0f;
    //private float jumpForce = 10.0f;

    public float turnSmoothTime = 0.1f;

    float turnSmoothVelocity;

   
    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y<0)
        {
            velocity.y = -2f;
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z)*Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }


        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

        }


        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);



        /*
        if(controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;             //Sets Gravity

            if(Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;                         //Jumping
            }
            else
            {
                verticalVelocity -= gravity * Time.deltaTime;         //falling if not on ground
            }
        }

        Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
        controller.Move(moveVector*Time.deltaTime);
        */
    }
  






}
