using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PlayerController : MonoBehaviour {

    private Quaternion targetRotation;
    private Rigidbody2D myRigidBody;
    public float turnSpeed = 5f;
    public float maxSpeed = 20f;
    public float horsePower = 10f;


    // Start is called before the first frame update
    void Start () {
        transform.position = new Vector3(1,1,1);
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate () {
        Debug.Log("Speed: " + myRigidBody.velocity.magnitude/100);

        float speed = myRigidBody.velocity.magnitude / 1000;


        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, turnSpeed*Mathf.Clamp(speed,-1,1) * Time.deltaTime);
    }

    public void SetTargetRotation(Quaternion newTargetRotation){
        targetRotation = newTargetRotation;
    }

    //Accelerates the rigidbody2D in the direction given (1 = forward, -1 = reverse, 0 = stop)
    public void Accelerate(int direction){
        float acceleration = horsePower * direction * Time.deltaTime;
        Debug.Log("acceleration: " + acceleration);
        myRigidBody.AddForce(transform.up * acceleration);

        if(direction == 0){
            myRigidBody.AddForce(myRigidBody.velocity * myRigidBody.velocity.magnitude / -10);
        }
        if(myRigidBody.velocity.magnitude > maxSpeed){
             myRigidBody.velocity = Vector3.ClampMagnitude(myRigidBody.velocity, maxSpeed);
         }
    }
}