using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    public List<AudioSource> audioSources = new List<AudioSource>();

    void OnEnable()
    {
        EnemyHealth.OnSetAudioSource += SetAudioSource;
    }
    void OnDisable()
    {
        EnemyHealth.OnSetAudioSource -= SetAudioSource;
    }

    void SetAudioSource(AudioSource audioSource){
        if(!audioSources.Contains(audioSource))
        else{
            audioSources.Remove(audioSource);
            cons
            ClearEmptiesFromList();
        }
    }

    void ClearEmptiesFromList(){
        audioSources.RemoveAll(item => item == null);

    }

}
