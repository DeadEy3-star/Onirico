using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterScript : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    private Rigidbody2D RB;
    
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RB.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime);
    }



}
