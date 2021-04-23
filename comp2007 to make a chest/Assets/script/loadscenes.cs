using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadscenes : MonoBehaviour
    
{
    public string scenesname;
    // Start is called before the first frame update
    public void nextscens()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void Update()
	{
		
	}
}
