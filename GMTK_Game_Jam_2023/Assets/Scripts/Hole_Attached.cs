using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole_Attached : MonoBehaviour
{
    public bool attached = false;

    public void Kill()
    {
        if (!attached)
        {
            Destroy(gameObject);
        }
    }
}
