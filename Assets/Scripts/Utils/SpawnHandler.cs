using UnityEngine;
using System.Collections;

public class SpawnHandler : MonoBehaviour
{
    [SerializeField]
    private Vector2 timeToSpawn;
    [SerializeField]
    private SpawnType spawnType;
    private GameObject objetcToSpawn;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        objetcToSpawn =  ChooseObject();
        StartCoroutine(SpawnController());
    }

    IEnumerator SpawnController(){
        time = Random.Range(timeToSpawn.x, timeToSpawn.y);
        yield return new WaitForSeconds(time);
        Instantiate(objetcToSpawn, transform.position, Quaternion.identity);
        StartCoroutine(SpawnController());
    }

    GameObject ChooseObject(){
        switch(spawnType){
            case SpawnType.Enemy:
                return Resources.Load<GameObject>(Constants.Get.ENEMY);
            default:
                return Resources.Load<GameObject>(Constants.Get.ENEMY);
        }
    }
}
