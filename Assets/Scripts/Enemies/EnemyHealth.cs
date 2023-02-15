using UnityEngine;
using System;

public class EnemyHealth : MonoBehaviour
{
    public static Action<AudioSource> OnSetAudioSource;
    public static Action OnEnemyDie;
    private AudioSource audioSource;
    private ParticleSystem bloodParticle;

    void Start()
    {
        bloodParticle = GetComponent<EnemySettings>().bloodParticle;
        audioSource = GetComponent<AudioSource>();
        OnSetAudioSource?.Invoke(audioSource);
    }   

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag(Constants.Get.BULLET)){
            OnSetAudioSource?.Invoke(audioSource);
            OnEnemyDie?.Invoke();
            var blood = Instantiate(bloodParticle, transform.position, Quaternion.identity);
            blood.Play();
            Destroy(this.gameObject);
        }
    }
}
