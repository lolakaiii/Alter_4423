using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationStateChanger : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] string currentState = "IdleAnimation";

    void Start(){
        ChangeAnimationState(currentState);
    }

    void Update() {

    }

    public void ChangeAnimationState(string newAnimationState) {

        if(newAnimationState == currentState){
            return;
        }
        
        currentState = newAnimationState;
        animator.Play(newAnimationState);
    }

}