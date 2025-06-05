using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public int maxHealthPoints;
    public UIManager uiManager;
    void Start()
    {
        uiManager= FindObjectOfType<UIManager>();
        healthPoints = maxHealthPoints;
    }

    // Update is called once per frame

    public void TakeDamage(int damagePoints)
    {
        if(healthPoints <= damagePoints)
        {
            //gameover
            return;
        }
        healthPoints -= healthPoints;
        uiManager.UpdateScore(healthPoints);
    }
    public void UpdateHealthPoints(int healthPoints)
    {
        healthPoints--;
        uiManager.UpdateScore(healthPoints);

    }
    
}
