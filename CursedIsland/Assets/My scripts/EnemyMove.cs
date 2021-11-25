using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    private NavMeshAgent Nav;
    private Transform TheTarget;
    private float DistanceToTarget;
    private int TargetNumber = 1;

    [SerializeField] int MaxTargets = 10;
    [SerializeField] Transform Target1;
    [SerializeField] Transform Target2;
    [SerializeField] Transform Target3;
    [SerializeField] Transform Target4;
    [SerializeField] Transform Target5;
    [SerializeField] Transform Target6;
    [SerializeField] Transform Target7;
    [SerializeField] Transform Target8;
    [SerializeField] Transform Target9;
    [SerializeField] Transform Target10;
    [SerializeField] float StopDistance = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        Nav = GetComponent<NavMeshAgent>();
        TheTarget = Target1;
    }

    // Update is called once per frame
    void Update()
    {
        DistanceToTarget = Vector3.Distance(TheTarget.position, transform.position);
        if (DistanceToTarget > StopDistance) 
        {
            Nav.SetDestination(TheTarget.position);
        }
        if (DistanceToTarget < StopDistance)
        {
            TargetNumber++;
            if (TargetNumber > MaxTargets)
            {
                TargetNumber = 1;
            }
            SetTarget();
        }
    }

    void SetTarget()
    {
        if (TargetNumber == 1)
        {
            TheTarget = Target1;
        }
        if (TargetNumber == 2)
        {
            TheTarget = Target2;
        }
        if (TargetNumber == 3)
        {
            TheTarget = Target3;
        }
        if (TargetNumber == 4)
        {
            TheTarget = Target4;
        }
        if (TargetNumber == 5)
        {
            TheTarget = Target5;
        }
        if (TargetNumber == 6)
        {
            TheTarget = Target6;
        }
        if (TargetNumber == 7)
        {
            TheTarget = Target7;
        }
        if (TargetNumber == 8)
        {
            TheTarget = Target8;
        }
        if (TargetNumber == 9)
        {
            TheTarget = Target9;
        }
        if (TargetNumber == 10)
        {
            TheTarget = Target10;
        }
    }
}
