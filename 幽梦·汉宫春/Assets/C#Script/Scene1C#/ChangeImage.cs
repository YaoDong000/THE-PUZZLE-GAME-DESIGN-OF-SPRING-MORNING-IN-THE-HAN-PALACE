using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeImage : MonoBehaviour
{
    public Sprite NewImage1;
    public Sprite NewImage2;
    public Sprite NewImage3;//声明
    public Sprite NewImage4;
    public Sprite NewImage5;
    public Sprite NewImage6;//声明

    public GameObject Btn;

    public int switchFlag = 1;  

    public void OnClick()
    {
        if (switchFlag == 1)
        {
            Btn.GetComponent<Image>().sprite = NewImage2;//切换图片
            switchFlag = 2;
            
        }
        else if(switchFlag == 2)
        {
            Btn.GetComponent<Image>().sprite = NewImage3;
            switchFlag = 3;
            
        }
        else if (switchFlag == 3)
        {
            Btn.GetComponent<Image>().sprite = NewImage4;
            switchFlag = 4;
           
        }
        else if (switchFlag == 4)
        {
            Btn.GetComponent<Image>().sprite = NewImage5;
            switchFlag = 5;

        }
        else if (switchFlag == 5)
        {
            Btn.GetComponent<Image>().sprite = NewImage6;
            switchFlag = 6;

        }
        else if (switchFlag == 6)
        {
            Btn.GetComponent<Image>().sprite = NewImage1;
            switchFlag = 1;

        }
        Debug.Log(switchFlag);
    }
    
}

