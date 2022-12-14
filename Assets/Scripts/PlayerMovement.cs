using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Components
    Rigidbody2D rb;

    // Player
    float moveSpeed = 5f;
    float speedLimiter = 0.7f;
    float inputHorizontal;
    float inputVertical;

    // Animations and states
    Animator animator;
    string currentState;
    const string PLAYER_IDLE = "Player_Idle";
    const string PLAYER_WALK_LEFT = "Player_Walk_Left";
    const string PLAYER_WALK_RIGHT = "Player_Walk_Right";
    const string PLAYER_WALK_UP = "Player_Walk_Up";
    const string PLAYER_WALK_DOWN = "Player_Walk_Down";

    Vector2 movement;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        animator.SetFloat("velocity", MathF.Abs(rb.velocity.x) + MathF.Abs(rb.velocity.y));
    }

    void FixedUpdate()
    {
        if (inputHorizontal != 0 || inputVertical != 0)
        {
            if (inputHorizontal != 0 && inputVertical != 0)
            {
                inputHorizontal *= speedLimiter;
                inputVertical *= speedLimiter;
            }
            rb.velocity = new Vector2(inputHorizontal * moveSpeed, inputVertical * moveSpeed);

            // Priority of animation
            if (inputHorizontal > 0)
            {
                ChangeAnimationState(PLAYER_WALK_RIGHT);
            }
            else if (inputHorizontal < 0)
            {
                ChangeAnimationState(PLAYER_WALK_LEFT);
            }
            else if (inputVertical > 0)
            {
                ChangeAnimationState(PLAYER_WALK_UP);
            }
            else if (inputVertical < 0)
            {
                ChangeAnimationState(PLAYER_WALK_DOWN);
            }
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
            ChangeAnimationState(PLAYER_IDLE);
        }
    }

    // Animation State changer
    void ChangeAnimationState(string newState)
    {
        // Stop animation from interrupting itself
        if (currentState == newState) return;

        // Play new animation
        animator.Play(newState);

        // Update current state
        currentState = newState;
    }
}
