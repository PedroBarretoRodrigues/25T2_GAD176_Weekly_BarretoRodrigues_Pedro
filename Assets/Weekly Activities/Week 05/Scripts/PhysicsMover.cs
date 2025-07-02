using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// Rolls the ball around using physics based on player input OR a target direction.
/// </summary>
public class PhysicsMover : MonoBehaviour
{
    [Header("Core Properties")]
    [SerializeField] private Rigidbody sphere;
    

    [Header("AI Functionality")]
    [SerializeField] private GameObject chaseTarget;
    [SerializeField] private bool isCurrentlyChasing;

    private void FixedUpdate()
    {
        if(isCurrentlyChasing == false)
        {
            // Player Movement
            if (sphere.velocity.magnitude <= 15)
            {
                // Input.GetAxis("Vertical") ...W/S
                // Input.GetAxis("Horizontal") ...A/D
                sphere.AddForce(Input.GetAxis("Horizontal") * 10, 0, Input.GetAxis("Vertical") * 10);
            }
        }
        else
        {
            // AI Chasing movement
            // We need a target
            // We want to move towards the target
            if(sphere.velocity.magnitude < 1)
            {
                // Need to know the DIRECTION from ME (the AI) to the TARGET (the PLAYER)
                // target.position - me.position
                sphere.AddForce(chaseTarget.transform.position - gameObject.transform.position);
              
               
                
            }
        }
        
    }



}
