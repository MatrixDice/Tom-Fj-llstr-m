using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalking : MonoBehaviour
{
    [SerializeField] Rigidbody2D rgb;
    [SerializeField] Transform flipTransform;
  //  [SerializeField] Transform raycastOrigin;
    [SerializeField] Transform groundCheckOrigin;
    [SerializeField] Transform wallCheckOrigin;
    [SerializeField] float speed = 3.0f;
    
    Vector2 moveDir = Vector2.right;

    void Update()
    {
        // Gravitation
        
        Vector2 newVel = rgb.velocity;
        newVel.x = (moveDir * speed).x;
        rgb.velocity = newVel; //Walking (Add rigidbody2D)
        

        // Flip when edge - raycast down, but not so far down
        // Raycast: Casts a ray, from point ”origin”, in direction ”direction”, of length ”maxDistance”,
        // against ALL COLLIDERS in the scene.

        //rgb.velocity = transform.TransformDirection(Vector2.right * 10.0f); //Walking

        // Flip when edge - raycast down, but not so far down
        //RaycastHit2D hit = Physics2D.Raycast(raycastOrigin.position, Vector2.down, 1.0f, LayerMask.GetMask("Default"));
        /*
        if (hit.collider != null)
        {
            return;
        }
        */

        
        // 2 raycasts' hits instead - ground and wall (Add go groundHit, wallHit)
        RaycastHit2D groundHit = Physics2D.Raycast(groundCheckOrigin.position, Vector2.down, 1.0f, LayerMask.GetMask("Default"));
        RaycastHit2D wallHit = Physics2D.Raycast(wallCheckOrigin.position, moveDir, 1.0f, LayerMask.GetMask("Default"));
        
        // Check if not collided with neither of the hit boxes
        //if (hit.collider != null)

        // An empty space in front of 
        if (groundHit.collider != null && wallHit.collider == null)
        {
            return;
        }

        Debug.Log("Innan IsTouchingLayers moveDir.x: " + moveDir.x);

        // Do not want to flip when falling
        if (rgb.IsTouchingLayers())
        {
            moveDir.x = -moveDir.x;
        }


        // If hit, still be left on the platform - flip with scale (Add go FlipPoint)
        Vector2 scale = flipTransform.localScale;

        Debug.Log("Innan hit, scale.x" + scale.x);
        
        scale.x = -scale.x;
        flipTransform.localScale = scale;
        Debug.Log("Efter hit, scale.x" + scale.x);

    }
}

