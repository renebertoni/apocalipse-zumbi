using UnityEngine;
using UnityEngine.AI;

public class EnemySettings : MonoBehaviour
{
    public float speed;
    public float stopDistance;
    NavMeshAgent navMesh;

    void Awake()
    {
        navMesh = GetComponent<NavMeshAgent>();
        navMesh.velocity = new Vector3(0.1f,0.1f,0.1f);
    }
    
    void Start()
    {
        if(navMesh) 
        {
            navMesh.speed = this.speed;
            navMesh.stoppingDistance = this.stopDistance;
        }
    }
}
