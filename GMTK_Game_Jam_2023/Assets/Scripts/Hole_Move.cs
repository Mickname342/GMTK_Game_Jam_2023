using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole_Move : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private LineRenderer lr;

    [Header("Attributes")]
    [SerializeField] private float maxPower = 10f;
    [SerializeField] private float power = 2f;
    [SerializeField] private float maxGoalSpeed = 4f;
    [SerializeField] private int timesShot = 0;
    [SerializeField] private int timesToShoot = 2;

    private bool isDragging;
    private bool inHole;
    public GameObject ball;
    bool attached = false;

    public Animator anim;
    private void Start()
    {
        //ball = GameObject.Find("Ball");
    }

    private void Update()
    {
        rb.angularVelocity = 0;
        PlayerInput();
    }

    private bool IsReady()
    {
        
        return rb.velocity.magnitude <= 0.3f;
    }

    private void PlayerInput()
    {
        if (!IsReady())
        {
            return;
        }

        if (IsReady() && timesShot == timesToShoot && attached == false)
        {
            anim.SetBool("Failed", true);
        }

        if (IsReady() && timesShot == timesToShoot && attached == true)
        {
            ball.SetActive(true);
        }

        Vector2 inputPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float distance = Vector2.Distance(transform.position, inputPos);

        if (Input.GetMouseButtonDown(0) && distance <= 0.5 && timesShot < timesToShoot)
        {
            DragStart();
        }

        if (Input.GetMouseButton(0) && isDragging == true)
        {
            DragChange(inputPos);
        }

        if (Input.GetMouseButtonUp(0) && isDragging == true)
        {
            DragRelease(inputPos);
        }
    }

    private void DragStart()
    {
        isDragging = true;
        lr.positionCount = 2;
    }

    private void DragChange(Vector2 pos)
    {
        Vector2 dir = (Vector2)transform.position - pos;

        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, (Vector2) transform.position - Vector2.ClampMagnitude((dir * power) / 2, maxPower / 2));
    }

    private void DragRelease(Vector2 pos)
    {
        float distance = Vector2.Distance((Vector2)transform.position, pos);
        lr.positionCount = 0;
        isDragging = false;

        if (distance < 1f)
        {
            return;
        }

        Vector2 dir = (Vector2)transform.position - pos;

        rb.velocity = Vector2.ClampMagnitude(dir * power, maxPower);
        timesShot++;
    }

    public void Attachement()
    {
        attached = true;
    }

    public void Deattached()
    {
        attached = false;
    }
}
