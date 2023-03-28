using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    RaycastHit2D hit;
    float moveSpeed = 10;
    public LayerMask mask;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveSpeed*Input.GetAxis("Horizontal"),rb.velocity.y);
        if (Physics2D.Raycast(transform.position, Vector2.down,1.1f,mask)&& Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector2.up*0.1f, ForceMode2D.Impulse);
        }
    }
}
