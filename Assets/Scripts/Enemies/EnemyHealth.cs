using UnityEngine;
using System;

public class EnemyHealth : MonoBehaviour
{
    public static Action<AudioSource> OnSetAudioSource; 

    string b = Constants.Get.BULLET;

    void Start()
    {
        var audioSource = GetComponent<AudioSource>();
        OnSetAudioSource?.Invoke(audioSource);
    }   

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag(Constants.Get.BULLET)){
            Destroy(this.gameObject);
        }
    }
}
