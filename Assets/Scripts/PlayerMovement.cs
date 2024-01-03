using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Can add any components and reference its functions
    public Rigidbody rigb;
    public float sidewaysForce;
    public float Forwardforce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //FixedUpdate is appritiated and is smooth
    void Update()
    {
        rigb.AddForce(0,0,Forwardforce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rigb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rigb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        
        if(rigb.position.y <-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
