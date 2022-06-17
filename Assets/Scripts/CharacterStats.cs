using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth {get; private set;}
    public int points = 0;
    void Awake(){
        currentHealth = maxHealth;
    }
    void Update (){
        if (Input.GetKeyDown(KeyCode.T)){
            TakeDamage(10);
        }
    }
    public void Heal (int health){
        if (currentHealth == maxHealth){
            Debug.Log(transform.name + " can't heal right now");
            currentHealth += 0;
        } else{
            currentHealth += health;
            Debug.Log(transform.name + " heals for " + health);
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
        if(other.name == "Pill")
        {
            Heal(5);
        }
    }
}
