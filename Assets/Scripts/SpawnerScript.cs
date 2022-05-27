using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour{
    public GameObject ItemPrefab;
    public float Radius = 1;

    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)) SpawnObjectAtRandom();
    }
    void SpawnObjectAtRandom(){
        Vector3 randomPos = Random.insideUnitCircle * Radius;
        Instantiate(ItemPrefab,randomPos,Quaternion.identity);
    }

}

