using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // game object reference edir player adli obyekte, playeri de mueyyen etmek ucun unityde vehicle-ni atiriq icine
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // makes camera follow the player object
        transform.position = player.transform.position + offset;

        // position shows coordinates
        // new Vector 3 yaradib buna kameranin koordinatlarini vererek kameraninin yerini ayarlayiriq
    }
}