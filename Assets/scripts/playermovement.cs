using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public CharacterController controller;
    public Animator anim;

    public float speed = 0;
    public float movespeed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundcheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask; 

    public Vector3 velocity;
    public Vector3 move;

    bool isGrounded;
    void Start(){
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0){
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        
        float z = Input.GetAxis("Vertical");

        move = transform.right * x + transform.forward *z;
        
        if(move == Vector3.zero){
            idel();
        }
        else{
            run();
        }
        
        move *= speed;
        controller.Move(move * Time.deltaTime);

        if(Input.GetButtonDown("Jump")){
            jump();
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }

    private void run(){
        speed = movespeed;
        anim.SetFloat("speed", 1f);
    }
    private void idel(){
        anim.SetFloat("speed", 0f);
    }
    private void jump(){
        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    }
}
