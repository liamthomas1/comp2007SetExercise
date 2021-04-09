using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public Slider slider;

 
    int saba;
    public void setmaxhealth(int health)
	{
        slider.maxValue = health;
        slider.value = health; 
	}
    public void Sethealth(int health)
	{
        slider.value = health;
	}

   
    


}
//liam google how to set the health bar systems up and running as well to test anything that might broke this systems


