using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float acceleration;
    public float max;
    public Movement movement;
    public float movementSpeed;
    [SerializeField] private Transform t;
    [SerializeField] private Rigidbody rb;
    
    private bool translateOn;
    // Start is called before the first frame update
    void Start()
    {
        translateOn = true;
      t = GetComponent<Transform>();
      rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    
    void FixedUpdate()
    {
        if(translateOn)
        {
            if(movement.getDown())
            {
                t.position+= Time.deltaTime * movementSpeed * -transform.forward;
            } 
            if(movement.getLeft())
            {
                t.position+= Time.deltaTime * movementSpeed * -transform.right;
               // t.Translate(-transform.right * movementSpeed);
            } 
            if(movement.getUp())
            {
                t.position+= Time.deltaTime * movementSpeed * transform.forward;
               // t.Translate(transform.forward * movementSpeed);
            } 
            if(movement.getRight())
            {
                t.position+= Time.deltaTime * movementSpeed * transform.right;
               // t.Translate(transform.right * movementSpeed);
            } 
        } 
    }
    
    void playerMove(Vector3 move) {
        if(rb.velocity.magnitude * acceleration > max)
        {
            rb.AddForce(move * -1);
        } else {
            rb.AddForce(move);
        }
    }
/*
    void FixedUpdate() {
        if(!translateOn){
            Vector3 move;
            if(movement.getDown()) {
                move = Vector3.back * acceleration * Time.deltaTime;
                Debug.Log(move);
                playerMove(move);
            }
            if(movement.getLeft()) {
                move = Vector3.left * acceleration * Time.deltaTime;
                playerMove(move);
            }
            if(movement.getUp()) {
                move = Vector3.forward * acceleration * Time.deltaTime;
                playerMove(move);
            }
            if(movement.getRight()) {
                move = Vector3.right * acceleration * Time.deltaTime;
                playerMove(move);
            }
        }
        
    }*/
}
