using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        if(other.name == "Player")
        {
            other.GetComponent<CharacterStats>().points++;
            Destroy(gameObject);
        }
    }
}
