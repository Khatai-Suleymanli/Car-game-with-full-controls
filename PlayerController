using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
   //Private variables

    private float speed = 25.0f;  // *20 yazmaq yerine speed deyiseni ile ede bilerik
    private float turnspeed = 55.0f;  //masinin donmesini temin eden deyisen
    private float horizontalInput;
    private float forwardInput;

    //camera deyismek ucun
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
        //PLAYER INPUTU ALIRIQ BURADA

        // Input.GetAxis edib horizontalInput deyisenine controllar veririk
        // "Horizontal" unity ayarlarinda input managerde donme controlunun adidir.
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        //We will move the wehicle forward
        //Translate cismi hereket etdirir; Vector3.forward ise translate(0, 0, 1) qisalmasidir, saniyede 60 m gedir.
        // sureti ayarlamaq ucun Time.deltaTime istifade edirik, bele olanda developerin ayarladigi suret nedirese onunla gedir
        // sureti artirmaq ucun ise * x kimi ede bilerik ve ya sped variable yaradib ede bilerik.

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);


        //we will turn the vehicle

        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);


        // HARDDDDD
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        };

    } 
}
