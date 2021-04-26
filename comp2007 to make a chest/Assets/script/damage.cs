using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public int minhealth = 0; 
    public int maxHealth = 100;
    public int currenthealth;
    public health Health;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxHealth;
        Health.setmaxhealth(maxHealth);
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
            TakeDamage(20);
		}
        if (Input.GetKeyDown(KeyCode.UpArrow))
		{
            TakeHealth(20);
		}
        
    }
    public void TakeDamage(int Damage)
	{
        if (currenthealth == minhealth) {}
        else
        {
            currenthealth -= Damage;
            Health.Sethealth(currenthealth);
        }
        if(currenthealth < minhealth)
		{
            currenthealth = minhealth;
            Health.Sethealth(currenthealth);
		}
	}
    public void TakeHealth (int oneup)
	{
        if(currenthealth == maxHealth) //this scpirt might break 
		{ 
		}
		else
		{
            currenthealth += oneup;
            Health.Sethealth(currenthealth);


        }
        if (currenthealth > maxHealth)
        {
            currenthealth = maxHealth;
            Health.Sethealth(currenthealth);
        }
    }
    
}

