using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Shoot : MonoBehaviour
{
    public Transform holeTransform;
    public int timesShoot = 1;
    public float power = 1;

    public GameObject blackScreen;
    public Animator reloadAnimator;
    // Start is called before the first frame update
    void Start()
    {
        GameObject hole = GameObject.Find("Goal");
        holeTransform = hole.transform;
        blackScreen = GameObject.Find("ReloadAnim");
        reloadAnimator = blackScreen.GetComponent<Animator>();
        Shoot();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void Shoot()
    {
        float angle = Mathf.Atan2(holeTransform.position.y - transform.position.y, holeTransform.position.x - transform.position.x) * Mathf.Rad2Deg;
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        float xcomponent = Mathf.Cos(angle * Mathf.PI / 180) * 10;
        float ycomponent = Mathf.Sin(angle * Mathf.PI / 180) * 10;
        Vector3 forceapplied = new Vector3(xcomponent, ycomponent, 0);
        print(forceapplied);
        rb.AddForce(forceapplied * power, ForceMode2D.Impulse);
        timesShoot++;
    }

    public void LoadNextLevel()
    {
        reloadAnimator.SetBool("Load", true);
    }

}
