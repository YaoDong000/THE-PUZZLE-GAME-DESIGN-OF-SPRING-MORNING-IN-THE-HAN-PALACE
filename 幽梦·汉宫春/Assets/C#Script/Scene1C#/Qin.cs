using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Qin : MonoBehaviour
{
    int i = 0;
    int[] Melody;
    int[] Answer;
    bool[] flag;

   
    public GameObject Password2;
    public GameObject MistakeTip;

    public AudioSource QinMusic;
    //public GameObject Text;

    void Start()
    {
        Melody = new int[]{ 0, 0, 0, 0, 0, 0 };
        Answer = new int[] { 3, 3, 5, 6, 3, 2 };
        flag = new bool[] { false,false,false,false,false,false};
        MistakeTip.SetActive(false);
    }
    private void Update()
    {
        if(i>=6)
        {
            for(int n = 0; n <= 5; n++)
            {
                if (!Melody[n].Equals(Answer[n]))
                {
                    
                    flag[n] = false;
                }
                else
                {
                    flag[n] = true;

                }
            }
            if (flag.Contains(false))
            {
                Debug.Log("曲有误！请重新弹奏");
                MistakeTip.SetActive(true);
               
            }
            else
            {
                Debug.Log("弹奏正确！");
                QinMusic.Play();//播放音乐
                Password2.SetActive(true);
            }

            i = 0;


        }
    }


    public void OnButtonGong()
    {
        if(i<=5)
        {
            Melody[i] = 1;
            for(int j=0;j<=5;j++)
            {
                Debug.Log(Melody[j]);
            }

           
            i++;
            
            
            Debug.Log(i);
           
        }
    }
    public void OnButtonShang()
    {
        if (i <= 5)
        {
            Melody[i] = 2;
            for (int j = 0; j <= 5; j++)
            {
                Debug.Log(Melody[j]);
            }

            
                i++;
            
            Debug.Log(i);

        }
    }
    public void OnButtonJue()
    {
        if (i <= 5)
        {
            Melody[i] = 3;
            for (int j = 0; j <= 5; j++)
            {
                Debug.Log(Melody[j]);
            }

            
                i++;
            
            Debug.Log(i);

        }
    }
    public void OnButtonZhi()
    {
        if (i <= 5)
        {
            Melody[i] = 5;
            for (int j = 0; j <= 5; j++)
            {
                Debug.Log(Melody[j]);
            }

            
                i++;
            
            Debug.Log(i);

        }
    }
    public void OnButtonYu()
    {
        if (i <= 5)
        {
            Melody[i] = 6;
            for (int j = 0; j <= 5; j++)
            {
                Debug.Log(Melody[j]);
            }
            i++;
            
            Debug.Log(i);

        }
        
      
    }
    
    public void YesClick()
    {
        MistakeTip.SetActive(false);
    }
}
