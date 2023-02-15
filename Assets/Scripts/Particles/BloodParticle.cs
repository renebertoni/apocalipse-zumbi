using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodParticle : MonoBehaviour
{
    ParticleSystem bloodParticle;
    // Start is called before the first frame update
    void Start()
    {
        bloodParticle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!bloodParticle.IsAlive()) 
            Destroy(this.gameObject);
    }
}
