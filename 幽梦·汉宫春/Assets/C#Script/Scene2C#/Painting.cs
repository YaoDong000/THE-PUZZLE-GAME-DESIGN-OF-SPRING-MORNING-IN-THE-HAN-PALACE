using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Painting : MonoBehaviour
{
    public GameObject WhiteImage, BlueImage, YellowImage, MouseImage,Tip;
    public GameObject WhiteColorButton, RedColorButton, BlueColorButton, YellowColorButton;
    public static int i = 0;
    public static int t = 0;

    private void Start()
    {
        //WhiteHair.SetActive(false);
        WhiteImage.SetActive(false);
        BlueImage.SetActive(false);
        YellowImage.SetActive(false);
        MouseImage.SetActive(false);
        Tip.SetActive(false);

    }
    public void OnClickWhiteColor()
    {
        i = 1;
        Debug.Log(i);
    }
   
    public void OnClickBlueColor()
    {
        i = 2;
        Debug.Log(i);
    }
    public void OnClickYellowColor()
    {
        i = 3;
    }
    public void OnClickRedColor()
    {
        i = 4;
    }
    public void OnClickHairButton()
    {
        if (i == 1)
        {
            Debug.Log("绘画白色！");
            WhiteImage.SetActive(true);
            i = 0;
            t++;
            WhiteColorButton.SetActive(false);

        }

        if (i == 2)
        {
            Debug.Log("绘画蓝色！");
            BlueImage.SetActive(true);
            i = 0;
            t++;
            BlueColorButton.SetActive(false);
        }


        if (i == 3)
        {
            Debug.Log("绘画黄色！");
            YellowImage.SetActive(true);
            i = 0;
            t++;
            YellowColorButton.SetActive(false);
        }

        if (i == 4)
        {
            Debug.Log("绘画唇彩");
            MouseImage.SetActive(true);
            i = 0;
            t++;
            RedColorButton.SetActive(false);
        }

        if(t == 4 )
        {
            Debug.Log("出现提示！");
            Tip.SetActive(true);
        }

        
    }
  

}
