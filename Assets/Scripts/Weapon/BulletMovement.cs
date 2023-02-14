using System.Collections;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;
    private Collider bulletCollider;
    private AudioSource audioSource;
    private Rigidbody bulletRigidbody;
    private MeshRenderer mesh;

    private void Start() {
        bulletCollider = GetComponent<Collider>();
        bulletCollider = GetComponent<Collider>();
        audioSource = GetComponent<AudioSource>();
        bulletRigidbody = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();

        audioSource.Play();
        StartCoroutine(DestroyBullet());
    }

    private void FixedUpdate() {
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
    }
    
    private void OnCollisionEnter(Collision other) {
        bulletCollider.enabled = false;
        bulletRigidbody.detectCollisions = false;
        mesh.enabled = false;
    }

    IEnumerator DestroyBullet(){
        yield return new WaitUntil(() => !audioSource.isPlaying );
        Destroy(this.gameObject);
    }
}
