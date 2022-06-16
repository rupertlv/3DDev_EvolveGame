using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour{

    public LayerMask movementMask;
    public Animator anim;

    Camera cam;
    PlayerMotor motor;


    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        // walking doesn't work
        // anim.SetFloat("vertical",Input.GetAxis("Vertical"));
        // anim.SetFloat("horizontal",Input.GetAxis("Horizontal"));

        if (Input.GetMouseButtonDown(0)){
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            

            if (Physics.Raycast(ray, out hit, 100, movementMask)){

                motor.MoveToPoint(hit.point);
            }

        }


    }
}   
