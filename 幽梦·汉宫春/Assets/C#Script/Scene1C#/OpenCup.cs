using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OpenCup : MonoBehaviour
{
    public GameObject Password1;
    public GameObject Password2;
    public GameObject Password3;
    public GameObject SceneABei;
    public GameObject SceneABeiLast;
    public GameObject SceneATable;
    public GameObject SceneAMain;//声明物体

    public Sprite SceneABLast;
    public Sprite DeskLast;
    public Sprite SceneAMainNoKey;//声明图片

    public int a;
    public int b;
    public int c;

   public void Check()
    {

        a = Password1.GetComponent<ChangeImage>().switchFlag;
        b = Password2.GetComponent<ChangeImage>().switchFlag;
        c = Password3.GetComponent<ChangeImage>().switchFlag;
        //标定a的值等于switchFlag
        if (a == 3 && b == 3 &&c == 2)
        {
            Debug.Log("正确！");
            SceneABeiLast.SetActive(true);
            SceneABei.SetActive(false);

            SceneABei.GetComponent<Image>().sprite = SceneABLast;
            SceneATable.GetComponent<Image>().sprite = DeskLast;
            SceneAMain.GetComponent<Image>().sprite = SceneAMainNoKey;//取得道具后将图片更改为无道具状态
        }
    }



   
  

}
