using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class GrassToBamboo1 : MonoBehaviour
{
    public static int Bam = 0;//声明全局变量
    public GameObject[] List;
    public Sprite OnK,GoK;
    
    public void OnClickGrass()
    {
        Bam = 4;
        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
        Debug.Log("点击！");
       
        

    }
    //取消掉点击效果
    void OnClickNK()
    {
        List = GameObject.FindGameObjectsWithTag("k");
        //查找所有关于Desk标签的物件，保存到数组List

        for(int i = 0; i < List.Length; i++)  //遍历数组，输出物件的名称
        {
            List[i].GetComponent<Image>().sprite = GoK;
        }

    }
    

    public void OnClickBamboo()
    {
        Bam = 5;
        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
    }
    public void OnClickCup()
    {
        Bam = 6;
        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;

    }
    public void OnClickFlower()
    {
        Bam = 7;
        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
    }
    public void OnClickBlackChess()
    {
        Bam = 8;
        
        
    }
    public void OnClickCharm()
    {
        Bam = 9;
        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
    }
    public void OnClickPray()
    {
        Bam = 10;
        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
    }
    public void OnClickFan()
    {
        Bam = 11;
        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
    }
    public void OnClickKey()
    {
        Bam = 12;
        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
    }
    


}

