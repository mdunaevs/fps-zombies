using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public float enemyHealth = 100.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0){
            EnemyDead();
        }
    }

    public void DeductHealth(float damageTaken){
        enemyHealth -= damageTaken;
    }

    public void EnemyDead(){
        Destroy(this.gameObject);
    }
}
