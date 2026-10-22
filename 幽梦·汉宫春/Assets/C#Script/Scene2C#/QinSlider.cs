using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QinSlider : MonoBehaviour
{
    public static float SliderValue1, SliderValue2, SliderValue3, SliderValue4;
    public GameObject Slider1, Slider2, Slider3, Slider4;
    public GameObject SceneDQin, SceneDQinLast, StoneBegin;

    private void Start()
    {
        SceneDQinLast.SetActive(false);
        StoneBegin.SetActive(false);
    }
    public void JianTingSlider()
    {
        SliderValue1 = Slider1.GetComponent<Slider>().value;
        SliderValue2 = Slider2.GetComponent<Slider>().value;
        SliderValue3 = Slider3.GetComponent<Slider>().value;
        SliderValue4 = Slider4.GetComponent<Slider>().value;
        if(SliderValue1 !=4 && SliderValue2 == 3 &&
            SliderValue3 == 5 && SliderValue4 == 4)
        {
            Debug.Log("成功！");
            SceneDQin.SetActive(false);
            SceneDQinLast.SetActive(true);
            StoneBegin.SetActive(true);
        }
    }


}
