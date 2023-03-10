using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    List<AudioSource> audioSources = new List<AudioSource>();

    void OnEnable()
    {
        EnemySpawn.SetAudioSource += DoSetAudioSource;
        GameHandler.GameOver += DoGameOver;
    }
    void OnDisable()
    {
        EnemySpawn.SetAudioSource -= DoSetAudioSource;
        GameHandler.GameOver -= DoGameOver;
    }

    void DoSetAudioSource(AudioSource audioSource)
    {
        if(!audioSources.Contains(audioSource))
        {
            audioSources.Add(audioSource);
        }
        else
        {
            audioSources.Remove(audioSource);
            ClearVoidsFromList();
        }
    }

    void ClearVoidsFromList()
    {
        audioSources.RemoveAll(item => !item);
    }

    void DoGameOver()
    {
        foreach (var item in audioSources)
        {
            item.Stop();
        }
    }
}
