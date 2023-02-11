using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    void OnEnable() {
        EnemyAttack.OnAttack += GameOver;
    }
    void OnDisable() {
        EnemyAttack.OnAttack -= GameOver;
    }
    void GameOver(){
        // Time.timeScale = 0;
    }
}
