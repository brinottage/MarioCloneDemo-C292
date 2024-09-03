using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueEnemy : MonoBehaviour
{
    [SerializeField] float moveSpeed; // SF allows to edit stuff from inside the editor
  
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // our rb is the rigidbody the object is attached to
    }

    // Update is called once per frame
    void Update()
    {
        

        Move();

    }

    private void Move()
    {

        // Endlessly moves left
        transform.Translate(-1 * Vector2.right * moveSpeed * Time.deltaTime);

    }

}
