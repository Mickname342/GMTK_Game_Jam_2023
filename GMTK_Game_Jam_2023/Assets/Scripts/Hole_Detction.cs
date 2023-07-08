using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole_Detction : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Wall"))
        {
            if (collision.CompareTag("Alligator"))
            {
                collision.gameObject.GetComponent <Alligator_Move> ().enabled = false;
            }
            if (collision.CompareTag("Ball"))
            {
                Rigidbody2D rb = collision.GetComponent <Rigidbody2D> ();
                rb.velocity = Vector2.zero;
            }
            Transform transCol = collision.transform;
            Collider2D col = collision.GetComponent<Collider2D>();
            col.isTrigger = true;
            collision.transform.SetParent(transform);
            transCol.position = transform.position + new Vector3(0,0,-2);
            Animator animator = col.GetComponent<Animator>();
            animator.SetBool("Die", true);
        }
        
    }
}
