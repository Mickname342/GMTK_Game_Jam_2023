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
            Destroy(collision.gameObject);
        }
        
    }
}
