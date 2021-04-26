using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damagetake : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider sliderred;


    int saba;
    public void setmaxLostheath(int losthealth)
    {
        sliderred.maxValue = losthealth;
        sliderred.value = losthealth;
    }
    public void Setlosthealth(int losthealth)
    {
        sliderred.value = losthealth;
    }

}
