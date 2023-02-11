using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    string b = Constants.Get.BULLET;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag(Constants.Get.BULLET)){
            Destroy(this.gameObject);
        }
    }
}
