using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket_1_Movement : MonoBehaviour
{
    public float movementSpeed;
    private void FixedUpdate()
    {
        float verticalInput = Input.GetAxisRaw("Vertical");
        this.GetComponent<Rigidbody2D>().velocity = movementSpeed * new Vector2(0, verticalInput);
    }
}
