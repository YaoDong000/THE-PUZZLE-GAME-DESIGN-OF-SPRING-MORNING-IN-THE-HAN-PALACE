using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DaoJu1 : MonoBehaviour
{
    public static int DaoJuNum = 0;//声明全局变量
    public Sprite OnK,GoK;
    public GameObject[] List;
    //取消掉点击效果
    void OnClickNK()
    {
        List = GameObject.FindGameObjectsWithTag("k");
        //查找所有关于Desk标签的物件，保存到数组List

        for (int i = 0; i < List.Length; i++)  //遍历数组，输出物件的名称
        {
            List[i].GetComponent<Image>().sprite = GoK;
        }

    }

    public void OnClickSeed()
    {
        DaoJuNum = 1;
        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
        Debug.Log("点击！");

    }

    public void OnClickYellowColor()
    {
        DaoJuNum = 2;
        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
        Debug.Log("点击！");

    }
    public void OnClickBlueColor()
    {
        DaoJuNum = 3;
        Debug.Log("加颜料2！");

        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
        Debug.Log("点击！");
    }
    public void OnClickYuRuYi()
    {
        DaoJuNum = 4;

        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
        Debug.Log("点击！");

    }
    public void OnClickCylinder1()
    {
        DaoJuNum = 5;

        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
        Debug.Log("点击！");

    }

    public void OnClickCylinder2()
    {
        DaoJuNum = 6;

        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
        Debug.Log("点击！");

    }

    public void OnClickCylinder3()
    {
        DaoJuNum = 7;

        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
        Debug.Log("点击！");

    }

    public void OnClickLeaf1()
    {
        DaoJuNum = 8;

        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
        Debug.Log("点击！");

    }

    public void OnClickLeaf2()
    {
        DaoJuNum = 9;

        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
        Debug.Log("点击！");

    }

    public void OnClickLeaf3()
    {
        DaoJuNum = 10;

        OnClickNK();
        GameObject K = this.transform.parent.gameObject;
        K.GetComponent<Image>().sprite = OnK;
        Debug.Log("点击！");

    }


}
