using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGhost : MonoBehaviour
{

    public Transform enemy;

    public Transform SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RespawnEnemy() 
    {
        Instantiate(enemy,SpawnPoint.transform.position,SpawnPoint.transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") 
        {
            RespawnEnemy();
        }
    }
}

