using UnityEngine;
using System;

public class EnemyAttackTrigger : MonoBehaviour
{
    public static Action OnHit;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag(Constants.Get.PLAYER))
            OnHit?.Invoke();
    }
}
