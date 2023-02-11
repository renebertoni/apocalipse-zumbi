using UnityEngine;
using UnityEngine.AI;
using System;

public class EnemyAttack : MonoBehaviour
{
    public static Action OnAttack;

    NavMeshAgent navMeshAgent;
    Animator animator;

    // Start is called before the first frame update
    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var isAttacking = navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance;
        animator.SetBool(Constants.Get.ATTACK, isAttacking);
    }

    void IsAttacking(){
        OnAttack?.Invoke();
    }
}
