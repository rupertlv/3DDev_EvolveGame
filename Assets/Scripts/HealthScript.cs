using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        if(other.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
