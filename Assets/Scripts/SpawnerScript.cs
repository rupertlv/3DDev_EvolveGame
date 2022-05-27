using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour{

    public GameObject Enemy;
    public int xPos;
    public int zPos;
    public int enemyCount;

    void Start(){
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop(){
        while (enemyCount < 15){
            xPos = Random.Range(1,100);
            zPos = Random.Range(1,100);
            Instantiate(Enemy,new Vector3(xPos, 35, zPos),Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            enemyCount += 1;
        }
    }

}

