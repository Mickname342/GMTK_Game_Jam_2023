using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sand_Slowdown : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rigidbody = collision.GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(rigidbody.velocity.x / 2, rigidbody.velocity.y / 2);
    }
}
