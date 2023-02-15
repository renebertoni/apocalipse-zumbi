using UnityEngine;

public class UIHandler : MonoBehaviour
{
    GameObject gameOver;
    // Start is called before the first frame update
    void Awake()
    {
        gameOver = GameObject.Find(Constants.Get.GAME_OVER_BACKGROUND);
        gameOver.SetActive(false);
    }

    void OnEnable() {
        GameHandler.OnGameOver += DoGameOver;
    }
    void OnDisable() {
        GameHandler.OnGameOver -= DoGameOver;
    }

    // Update is called once per frame
    void DoGameOver()
    {
        gameOver.SetActive(true);
    }
}
