using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
   [SerializeField] float moveSpeed; // SF allows to edit stuff from inside the editor

    private Rigidbody2D rb;

    private Boolean right;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // our rb is the rigidbody the object is attached to

        right = true;
    }

    // Update is called once per frame
    void Update()
    {

        BackForth();

    }

    private void BackForth()
    {

        // Moves Right
          // moveInput decides direction, moveSpeed decides speed, the Vector is (1, 0)
        if (right) {
            transform.Translate(1 * Vector2.right * moveSpeed * Time.deltaTime);
        }

        // Moves Left
          // moveInput decides direction, moveSpeed decides speed, the Vector is (1, 0)
        if (!right) {
             transform.Translate(1 * Vector2.right * moveSpeed * Time.deltaTime);
        }

    }

}
