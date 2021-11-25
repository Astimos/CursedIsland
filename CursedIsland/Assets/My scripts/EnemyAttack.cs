using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttack : MonoBehaviour
{
    private NavMeshAgent Nav;
    private NavMeshHit hit;
    private bool blocked = false;
    private bool RunToPlayer = false;
    private float DistanceToPlayer;
    private bool IsChecking = true;
    private int FailedChecks = 0;

    [SerializeField] int MaxChecks = 3;
    [SerializeField] Transform Player;
    [SerializeField] GameObject Enemy;
    [SerializeField] float MaxRange = 35.0f;
    [SerializeField] Animator Anim;
    [SerializeField] float ChaseSpeed = 8.5f;
    [SerializeField] float WalkSpeed = 1.6f;
    [SerializeField] float AttackDistance = 2.3f;
    [SerializeField] float AttackRotateSpeed = 2.0f;
    [SerializeField] float CheckTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        Nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        DistanceToPlayer = Vector3.Distance(Player.position, Enemy.transform.position);
        if (DistanceToPlayer < MaxRange) 
        {
            if (IsChecking == true) 
            {
                IsChecking = false;

                blocked = NavMesh.Raycast(transform.position, Player.position, out hit, NavMesh.AllAreas);

                if (blocked == false) 
                {
                    Debug.Log("I Can See the Player");
                    RunToPlayer = true;
                }
                if (blocked == true) 
                {
                    Debug.Log("Where did the player go");
                    RunToPlayer = false;
                    Anim.SetInteger("State", 1);
                }

                StartCoroutine(TimedCheck());
            }
        }
    }

    IEnumerator TimedCheck() 
    {
        yield return new WaitForSeconds(CheckTime);

        IsChecking = true;
    }
}