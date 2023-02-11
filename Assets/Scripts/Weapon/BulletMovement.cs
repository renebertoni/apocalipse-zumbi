using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;

    private void FixedUpdate() {
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
    }
    
    private void OnCollisionEnter(Collision other) {
        Destroy(this.gameObject);
    }
}
