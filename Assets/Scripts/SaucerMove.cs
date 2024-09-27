using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaucerMove : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

      if (Input.GetKey(KeyCode.W)){
        rb.AddForce(0, 0, 1f, ForceMode.Impulse);
      }

    }
}
