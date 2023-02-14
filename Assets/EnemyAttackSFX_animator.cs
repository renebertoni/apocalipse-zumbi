using UnityEngine;

public class EnemyAttackSFX_animator : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       var enemyAttack = animator.gameObject.GetComponent<EnemyAttack>();
       enemyAttack.PlaySound();
    }
}
