using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float MovementSpeed = 1;

    public Rigidbody2D rigidBody;

    public Vector2 movement;
    public Vector2 mousePosition;

    public Camera cam;
    
    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);

    }

    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + movement 
            * (MovementSpeed * Time.fixedDeltaTime));

        Vector2 lookDir = mousePosition - rigidBody.position;

        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90;

        rigidBody.rotation = angle;
    }
}
