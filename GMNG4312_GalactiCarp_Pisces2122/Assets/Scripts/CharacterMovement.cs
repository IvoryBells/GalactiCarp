using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    public Camera cam;
    
    

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    
   
    public float speed = 6f;
    public float gravity = -9.81f;
    public float jumpHeight = 3.0f;

    Vector3 velocity;
    public bool isGrounded;
    

    public float turnSmoothTime = 0.1f;

    float turnSmoothVelocity;

    
    void Start()
    {

        cam = FindObjectOfType<Camera>();
        /*
        if(cam = null)
        {
            cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        }
       */
    }
    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y<0)
        {
            velocity.y = -2f;
        }

        
        // Movement
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.transform.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }


        //Jump
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

        }


        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        
    }
  






}
