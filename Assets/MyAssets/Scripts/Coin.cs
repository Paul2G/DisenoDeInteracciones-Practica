using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Interactable
{
    Rigidbody rb;

    public Vector3 moveDirection;

    public float moveForce = 5f;

    void Awake ()
    {
        rb = GetComponent<Rigidbody>();
    }

    public override void Interact()
    {
        base.Interact();

        if(rb!=null)
        {
            rb.AddForce(moveDirection * moveForce, ForceMode.Force);
        }
    }
}
