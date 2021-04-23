using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourchange : MonoBehaviour
{
    public Color Disco;
    public float R, G, B, A;
    public string onoroff;
    public Renderer discoRender;
    // Start is called before the first frame update
    void Start()
    {
        A = 1;
        discoRender = gameObject.GetComponent<Renderer>();
        onoroff = "off";
    }
    public void colourOnOf()
	{

        if (onoroff == "off")
		{
            onoroff = "on";
            Disco = new Color(R, G, B, A);
            discoRender.material.color = Disco;
        }
        else
		{
            onoroff = "off";
		}
	}

    // Update is called once per frame
    void Update()
    {
        if (onoroff == "on")
        {
            R = R + 1;

         
        }
    }
}
