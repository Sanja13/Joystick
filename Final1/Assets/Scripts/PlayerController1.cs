using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Animator animator;
    private bool isWalking = false;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Check for touch phases
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Check if the touch started on the left or right half of the screen
                    if (touch.position.x < Screen.width / 2)
                    {
                        // Left side of the screen, move the player left
                        MoveLeft();
                    }
                    else
                    {
                        // Right side of the screen, move the player right
                        MoveRight();
                    }
                    break;

                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    // Stop the player's movement when touch ends or is canceled
                    StopMoving();
                    break;
            }
        }
    }

    private void MoveForward()
    {
        // Set the animator parameter for moving forward
        animator.SetBool("isWalking", true);
        isWalking = true;

        // Move the player forward
        transform.Translate(0f, 0f, moveSpeed * Time.deltaTime);
    }

    private void StopMoving()
    {
        // Set the animator parameter for moving forward to false
        animator.SetBool("isWalking", false);
        isWalking = false;
    }

    private void MoveLeft()
    {
        // Move the player left
        transform.Translate(-moveSpeed * Time.deltaTime, 0f, 0f);
    }

    private void MoveRight()
    {
        // Move the player right
        transform.Translate(moveSpeed * Time.deltaTime, 0f, 0f);
    }
}

