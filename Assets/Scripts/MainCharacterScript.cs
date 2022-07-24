using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterScript : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D RB;
    private Vector2 MoveDirecction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }


    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        MoveDirecction = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        RB.velocity = new Vector2(MoveDirecction.x * movementSpeed, MoveDirecction.y * movementSpeed);
    }

    private void OnAnimatorMove()
    {
        
    }


}
