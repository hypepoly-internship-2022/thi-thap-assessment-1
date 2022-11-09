using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

  public Rigidbody rb;

  void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       rb.AddForce(0, 0, 500*Time.deltaTime);
    }
}
