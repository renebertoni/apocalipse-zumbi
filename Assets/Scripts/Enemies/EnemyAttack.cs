using UnityEngine;
using UnityEngine.AI;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioAttack;
    private NavMeshAgent navMeshAgent;
    private Animator animator;

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

    public void PlaySound(){
        audioAttack.Play();
    }
}
