using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_AttachHole : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hole"))
        {
            print("I have to attach");
            Hole_Move hole_Move = collision.GetComponent<Hole_Move>();
            hole_Move.Attachement();
            Transform hole = collision.transform;
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
            hole.position = gameObject.transform.position;
            Hole_Attached attached = collision.GetComponent<Hole_Attached>();
            attached.attached = true;
            
        }
    }
}
