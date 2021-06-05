using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRagdoll : MonoBehaviour
{
    public float speed;
    public float strafeSpeed;

    public Rigidbody forearmL;
    public Rigidbody shoulderL;
    public Rigidbody forearmR;
    public Rigidbody shoulderR;
    public Rigidbody kneeR;
    public Rigidbody caviarR;
    public Rigidbody kneeL;
    public Rigidbody caviarL;
    public Rigidbody teepL;
    public Rigidbody teepR;
    public Rigidbody head;
    public Rigidbody body;

    void Start()
    {
    }


    void FixedUpdate()
    {




        if(shoulderL.transform.eulerAngles.x < -90f){
            shoulderL.transform.Rotate(0,0,0);
        }
        if(shoulderL.transform.eulerAngles.x > 90f){
            shoulderL.transform.Rotate(0,0,0);
        }
        if(shoulderL.transform.eulerAngles.x < -90f){
            shoulderL.transform.Rotate(0,0,0);
        }
        if(shoulderL.transform.eulerAngles.x > 90f){
            shoulderL.transform.Rotate(0,0,0);
        }




        if(Input.GetKey(KeyCode.W)){
            forearmL.AddForce(new Vector3(0, speed, 0));
        }
        if(Input.GetKey(KeyCode.A)){
            shoulderL.AddForce(new Vector3(0, speed, 0));
        }
        if(Input.GetKey(KeyCode.S)){
            forearmR.AddForce(new Vector3(0, speed, 0));
        }
        if(Input.GetKey(KeyCode.D)){
            shoulderR.AddForce(new Vector3(0, speed, 0));
        }


        if(Input.GetKey(KeyCode.E)){
            //kneeL.AddForce(new Vector3(0, speed, 0));
            kneeL.AddForce(kneeL.transform.right * speed);
        }
        if(Input.GetKey(KeyCode.R)){
            caviarL.AddForce(new Vector3(0, speed, 0));
        }
        if(Input.GetKey(KeyCode.F)){
            //kneeR.AddForce(new Vector3(0, speed, 0));
            kneeR.AddForce(kneeR.transform.right * speed);
        }
        if(Input.GetKey(KeyCode.G)){
            caviarR.AddForce(new Vector3(0, speed, 0));
        }
        if(Input.GetKey(KeyCode.C)){
            teepL.AddForce(new Vector3(0, speed, 0));
        }
        if(Input.GetKey(KeyCode.V)){
            teepR.AddForce(new Vector3(0, speed, 0));
        }


        if(Input.GetKey(KeyCode.X)){
            head.AddForce(new Vector3(0, speed, 0));
        }
        if(Input.GetKey(KeyCode.Z)){
            body.AddForce(-body.transform.right * speed);
        }
    }
}
