using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] Movement movement;


    void Awake () {
        movement = GetComponent<Movement>(); 
    }



    void Start() {
    }


    void FixedUpdate() { 
        Vector3 vel = Vector3.zero;
        if(Input.GetKey(KeyCode.W)) { 
            vel.y = 5;
        }
        if (Input.GetKey(KeyCode.S)) { 
            vel.y = -5; 
        }
        if (Input.GetKey(KeyCode.A)) { 
            vel.x = -5; 
        }
        if(Input.GetKey(KeyCode.D)) { 
            vel.x = 5; 
        }
        
        movement.MoveRB(vel);
    }


    void Update()
    {
        Vector3 vel = Vector3.zero; 
        if(Input.GetKey(KeyCode.W)) { 
            vel.y = 1;
        }
        else if (Input.GetKey(KeyCode.S)) { 
            vel.y = -1; 
        }
        else if (Input.GetKey(KeyCode.A)) { 
            vel.x = -1; 
        }
        else if(Input.GetKey(KeyCode.D)) { 
            vel.x = 1; 
        }
        movement.MoveRB(vel);

    }
}
