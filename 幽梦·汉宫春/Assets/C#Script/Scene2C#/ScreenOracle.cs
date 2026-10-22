using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenOracle : MonoBehaviour
{
    //更改Screen甲骨文字符图片
    public Sprite Oracle1;
    public Sprite Oracle2;
    public Sprite Oracle3;
    public Sprite Oracle4;
    public Sprite Oracle0;//声明

    public GameObject Oracle;

    public int Flag = 0;
    private void Start()
    {
        Oracle.GetComponent<Image>().sprite = Oracle0;
    }
    public void OnClickOracle()
    {
        if (Flag == 0)
        {
            Oracle.GetComponent<Image>().sprite = Oracle1;//切换图片
            Flag = 1;

        }
        else if (Flag == 1)
        {
            Oracle.GetComponent<Image>().sprite = Oracle2;//切换图片
            Flag = 2;

        }
        else if (Flag == 2)
        {
            Oracle.GetComponent<Image>().sprite = Oracle3;//切换图片
            Flag = 3;

        }
        else if (Flag == 3)
        {
            Oracle.GetComponent<Image>().sprite = Oracle4;//切换图片
            Flag = 4;

        }
        else if (Flag == 4)
        {
            Oracle.GetComponent<Image>().sprite = Oracle0;//切换图片
            Flag = 0;

        }
        Debug.Log(Flag);
    }

}
