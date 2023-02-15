using UnityEngine;
using TMPro;
using System;

public class UI_Counter : MonoBehaviour
{
    public TMP_Text textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TMP_Text>();
        textMeshPro.text = "0";
    }

    private void OnEnable() {
        EnemyHealth.OnEnemyDie += AddCounter;
    }
    private void OnDisable() {
        EnemyHealth.OnEnemyDie -= AddCounter;
    }

    void AddCounter(){
        var number = Convert.ToInt32(textMeshPro.text);
        var numberStr = number + 1;
        textMeshPro.text = numberStr.ToString();
    }
}
