using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float speed = 1;
    [SerializeField] AnimationStateChanger animationStateChanger;
    [SerializeField] Transform body;

    Rigidbody2D rb;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }


    public void MoveTransform(Vector3 vel) { 
        transform.position += vel * speed * Time.deltaTime;
    }

public void MoveRB(Vector3 vel) { 

    rb.velocity = vel * speed;
    
    if(vel.magnitude > 0) {
        
        if(vel.x > 0) {
            animationStateChanger.ChangeAnimationState("WalkingLeft");
        } 
        else if(vel.x < 0) {
            animationStateChanger.ChangeAnimationState("WalkingRight");
        }
        else if(vel.y > 0) {
            animationStateChanger.ChangeAnimationState("WalkingUp");
        } 
        else if(vel.y < 0) {
            animationStateChanger.ChangeAnimationState("WalkingDown");
        }
    }
    else {
        animationStateChanger.ChangeAnimationState("IdleAnimation"); 
    }
    rb.MovePosition(transform.position + (vel*Time.fixedDeltaTime) );
}

    public void MoveToward(Vector3 targetPosition){
        Vector3 direction = targetPosition - transform.position;
        direction = Vector3.Normalize(direction);
        MoveRB(direction);
    }

    public void Stop(){
        MoveRB(Vector3.zero);
    }

}
