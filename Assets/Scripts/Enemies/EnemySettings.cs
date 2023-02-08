using UnityEngine;
using UnityEngine.AI;

public class EnemySettings : MonoBehaviour
{
    public float speed;
    public float stopDistance;
    NavMeshAgent m_navMesh;

    public NavMeshAgent navMesh
    {
        get{ return m_navMesh; }
    }

    void Awake()
    {
        m_navMesh = GetComponent<NavMeshAgent>();
    }
    
    void Start()
    {
        if(m_navMesh) 
        {
            m_navMesh.speed = this.speed;
            m_navMesh.stoppingDistance = this.stopDistance;
        }
    }
}
