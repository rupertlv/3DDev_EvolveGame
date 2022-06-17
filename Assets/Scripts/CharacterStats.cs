using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth {get; private set;}
    public Stat damage;
    public int points = 0;
    public int speed = 20;

    void Awake(){
        currentHealth = maxHealth;
    }

    void Update (){
        if (Input.GetKeyDown(KeyCode.T)){
            TakeDamage(10);
        }
    }

    public void TakeDamage (int damage){
        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");
        if (currentHealth <= 0){
            Die();
        }
    }
    public virtual void Die(){
        Application.LoadLevel(0);
    }
    private void OnGUI(){
        GUI.Label(new Rect(10,10,100,20),"Score : " + points);
        GUI.Label(new Rect(10,30,100,20),"Health : " + currentHealth);
    }

    private void OnTriggerEnter(Collider other){
        if(other.name == "Enemy")
        {
            TakeDamage(10);
        }
    }
}
