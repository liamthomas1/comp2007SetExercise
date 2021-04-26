using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redfill : MonoBehaviour
{
	public damagetake Damagetake;
	public int MinDamage = 0;
	public int MaxDamage = 100;
	public int currentdamage;
	public int gain, take = 20;
	// this is the same idea as damage i know name for demage is health but this is for red bit it
	void Start() // this will set the the health bar when it start 
	{
		currentdamage = MaxDamage;
		Damagetake.setmaxLostheath(MaxDamage);
	}
	 void Update()
	{
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			gainDamage(20);
		}
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			Takedamage(20);
		}
		
	}
	public void gainDamage(int Reddamage)
	{
		if (currentdamage > MaxDamage)
		{

		}
		else
		{



			currentdamage += Reddamage;
			Damagetake.Setlosthealth(currentdamage);

		}
		}
	public void Takedamage (int GreenReturn)
	{
		if (currentdamage < MinDamage) { }
		else
		{
			currentdamage -= GreenReturn;
			Damagetake.Setlosthealth(currentdamage);
		}
	}

}
