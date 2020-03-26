using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerMovment movment;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    private float screenWidth;
    //Time.deltaTime --> Amount of second since the computer drew the last frame

    // Start is called before the first frame update
    void Start() {
        screenWidth = Screen.width;
        //rb.useGravity = false;
        //rb.AddForce(X, Y, Z, ForceMode);
    }

    // Update is called once per frame
    void FixedUpdate() {//FixedUpdate is better for physics stuff
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);//Time.deltaTime --> Amount of second since the computer drew the last frame
        
        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }if (Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        int i = 0;
        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > screenWidth / 2)
            {
                //Right Movment
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetTouch(i).position.x < screenWidth / 2)
            {
                //LEft Movment
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            ++i;
        }

        if (rb.position.y < -1f)
        {
            movment.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
