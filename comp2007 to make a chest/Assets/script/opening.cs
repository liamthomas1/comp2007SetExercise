using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opening : MonoBehaviour
{

    public float turnspeed = 50f;
    // Update is called once per frame
    //this is a test for this
    public float open = -170;
    public float close = -60;
    
    void Update()
    {

        // this is how the lid is being open and close 
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(Vector3.left, turnspeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(Vector3.right, turnspeed * Time.deltaTime);

    }
}
