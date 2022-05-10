using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
   //Private variables

    private float speed = 25.0f;
    private float turnspeed = 55.0f; 
    private float horizontalInput;
    private float forwardInput;

    //code lines for changing the camera view. Just create a second camera and add it to the vehicle
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        // Input.GetAxis - to get input key
        // "Horizontal" means horizontal arrows keys
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);


        //we will turn the vehicle

        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);


        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        };

    } 
}
