using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMovement : MonoBehaviour {
    
    //physics
    public Rigidbody2D bodyOfShip;
    //variables to store input
    public float movementSpeed = 300;
    public float h, v;
    public float rotationSpeed = 10;


    void Start () {
        bodyOfShip = gameObject.GetComponent<Rigidbody2D>(); // finding and allocating rigid body to bodyOfShip Variable

	}
	
	
	void Update () {
        getInput();
        getRotation();
        //methods i have created below
    }

    //fixed update results in smoother movement
    private void FixedUpdate()
    {
        //value between -1 and 1
        bodyOfShip.velocity = new Vector2(h, v) * movementSpeed * Time.deltaTime; //vector2 direction we are moving in
        //delta time gives percentage on how to move based on frame rate
        
    }

    public void getInput()
    {
        // get the input for the W,A,S,D and the arrow keys
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");

    }

    public void getRotation()
    {
        if (Input.GetKey(KeyCode.E))
        {
            //rotate right
            transform.Rotate(0, 0, -rotationSpeed);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            //rotate left
            transform.Rotate(0, 0, rotationSpeed);
        }
    }
}
