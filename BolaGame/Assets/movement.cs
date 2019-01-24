using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour{

    private Rigidbody rb;
    public float speed;
    public float speedJump;

    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveH, 0.0f, moveV)*speed;
        rb.AddForce(movement);

         if (Input.GetKeyDown(KeyCode.Space))
          {
              GetComponent<Rigidbody>().velocity = Vector3.up * speedJump;
                            
          }
    }
}
