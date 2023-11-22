using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D myRigidbody;
    [SerializeField] float movementSpeed = 10.0f;
    [SerializeField] float jumpingSpeed = 8.0f;


    // Update is called once per frame
    void Update()
    {
        // Handle input
        Vector2 inputDir = Vector2.zero;
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) // D or Right arrow
        {
            inputDir.x += 1.0f;
        }
        
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) // A or Left arrow
            {
            inputDir.x -= 1.0f;
        }

        // Quit
        if (Input.GetKey(KeyCode.Escape)) // Escape
        {
            Application.Quit();
        }

        // Handle jump
        //bool recievedJumpInput = (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)); // button W or space, GetKeyDown för 1 hopp, GetKey flera hopp
        bool recievedJumpInput = (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)); // W or Up arrow
        bool touchingGround = myRigidbody.IsTouchingLayers();

        if (recievedJumpInput && touchingGround)
        {
            myRigidbody.AddForce(Vector2.up * jumpingSpeed, ForceMode2D.Impulse); // Impulse = quick kickup and don't do that again
        }

        // Apply Velocity
        Vector2 moveDir = inputDir * movementSpeed;
        moveDir.y = myRigidbody.velocity.y;
        myRigidbody.velocity = moveDir;

    }
}
