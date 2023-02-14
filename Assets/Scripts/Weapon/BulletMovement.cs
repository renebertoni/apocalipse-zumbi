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
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        StartCoroutine(DestroyBullet());
    }

    private void FixedUpdate() {
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
    }
    
    private void OnCollisionEnter(Collision other) {
        GetComponent<Collider>().enabled = false;
        GetComponent<Rigidbody>().detectCollisions = false;
        GetComponent<MeshRenderer>().enabled = false;
    }

    IEnumerator DestroyBullet(){
        yield return new WaitUntil(() => !audioSource.isPlaying );
        Destroy(this.gameObject);
    }
}
