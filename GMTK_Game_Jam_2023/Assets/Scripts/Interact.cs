using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interact : MonoBehaviour
{
    public UnityEvent Collide;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collide.Invoke();
    }
}
