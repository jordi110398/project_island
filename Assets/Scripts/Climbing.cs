using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbing : MonoBehaviour
{

    [Header("Referencies")]
    public Transform orientation;
    public Rigidbody rb;
    public FirstPersonController fpc;
    public LayerMask whatIsWall;

    [Header("Escalar")]
    public float climbSpeed;
    public float maxClimbTime;
    private float climbTimer;

    private bool climbing;

    [Header("Detecció")]
    public float detectionLength;
    public float sphereCastRadius;
    public float maxWallLookAngle;
    private float wallLookAngle;

    private RaycastHit frontWallHit;
    private bool wallFront;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        WallCheck();
        StateMachine();
        if (climbing) ClimbingMovement();
    }

    private void StateMachine()
    {
        // Estat 1 - Escalant
        if (wallFront && Input.GetKey(KeyCode.W) && wallLookAngle < maxWallLookAngle)
        {
            if (!climbing && climbTimer > 0) StartClimbing();
            // timer
            if (climbTimer > 0) climbTimer -= Time.deltaTime;
            if (climbTimer < 0) StopClimbing();
        }
        // Estat 3 - Res
        else
        {
            if (climbing) StopClimbing();
        }
    }

    private void WallCheck()
    {
        wallFront = Physics.SphereCast(transform.position, sphereCastRadius, orientation.forward, out frontWallHit, detectionLength, whatIsWall);
        wallLookAngle = Vector3.Angle(orientation.forward, -frontWallHit.normal);
        if (fpc.Grounded)
        {
            climbTimer = maxClimbTime;
        }
    }

    private void StartClimbing()
    {
        climbing = true;
    }

    private void ClimbingMovement()
    {
        rb.velocity = new Vector3(rb.velocity.x, climbSpeed, rb.velocity.z);
    }

    private void StopClimbing()
    {
        climbing = false;
    }
}
