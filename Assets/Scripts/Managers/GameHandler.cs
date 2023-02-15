using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public static Action OnGameOver;

    private void Start() {
        Time.timeScale = 1;
    }

    void OnEnable() {
        EnemyAttackTrigger.OnHit += DoGameOver;
        PlayerInputs.DontShot += RestartScene;
    }

    void OnDisable() {
        EnemyAttackTrigger.OnHit -= DoGameOver;
        PlayerInputs.DontShot -= RestartScene;
    }

    void RestartScene()
    {
        SceneManager.LoadScene(Constants.Get.LEVEL_01);
    }

    void DoGameOver(){
        OnGameOver?.Invoke();
        Time.timeScale = 0;
    }
    
}
