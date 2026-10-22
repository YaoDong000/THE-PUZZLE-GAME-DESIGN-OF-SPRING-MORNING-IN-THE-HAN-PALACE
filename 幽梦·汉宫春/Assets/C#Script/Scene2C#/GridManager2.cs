using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridManager2 : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> grid;//格子列表，用来存储所有物品
    public GameObject leaf,seed,yuruyi, cylinder, color,leaf2,leaf3,color2, cylinder1, cylinder2, cylinder3;//物品对象，把prefab添加到这里

    public GameObject ButtonLeaf,ButtonSeed,ButtonYuRuYi, ButtonCylinder1, ButtonCylinder2, ButtonCylinder3,
        ButtonColor, ButtonLeaf2,ButtonLeaf3, StoneBegin, StoneLast;
    public GameObject SceneC3People, SceneCMain;
    public Sprite YuRuYiLast, YuRuYiMainLast;
    
    public void ClickLeaf()
    {
        AddItem(leaf);
        //调用添加物品的方法
        ButtonLeaf.SetActive(false);


    }
    public void ClickSeed()
    {
        AddItem(seed);
        //调用添加物品的方法
        ButtonSeed.SetActive(false);

    }
    public void ClickYuRuYi()
    {
        AddItem(yuruyi);
        //调用添加物品的方法
        ButtonYuRuYi.SetActive(false);
        SceneC3People.GetComponent<Image>().sprite = YuRuYiLast;
        SceneCMain.GetComponent<Image>().sprite = YuRuYiMainLast;
    }

    

    public void ClickColor()
    {
        AddItem(color);
        //调用添加物品的方法
        ButtonColor.SetActive(false);

    }

    public void ClickLeaf2()
    {
        AddItem(leaf2);
        //调用添加物品的方法
        ButtonLeaf2.SetActive(false);

    }
    public void ClickLeaf3()
    {
        AddItem(leaf3);
        //调用添加物品的方法
        ButtonLeaf3.SetActive(false);

    }

    public void ClickCylinder1()
    {
        AddItem(cylinder1);
        //调用添加物品的方法
        ButtonCylinder1.SetActive(false);

    }
    public void ClickCylinder2()
    {
        AddItem(cylinder2);
        //调用添加物品的方法
        ButtonCylinder2.SetActive(false);

    }
    public void ClickCylinder3()
    {
        AddItem(cylinder3);
        //调用添加物品的方法
        ButtonCylinder3.SetActive(false);

    }

    public void ClickStoneBegin()
    {
        StoneBegin.SetActive(false);
        StoneLast.SetActive(true);

    }
    public void ClickStoneLast()
    {
        AddItem(color2);
        //调用添加物品的方法
        StoneLast.GetComponent<Button>().enabled = false;//禁用StoneLast的button属性

    }
    public void AddItem(GameObject _Prefab)
    //查找每个格子，寻找空格子的物体
    {

        for (int i = 0; i < grid.Count; i++)
        {
            //通过查找名字来寻找物体，判断格子内是否有物品存在

            int isHaving = grid[i].transform.GetComponentsInChildren<Transform>(true).Length;

            //如果当前格子有物品存在
            if (isHaving > 1)
                continue;
            else if (isHaving <= 1)
            {   //当前的空格子
                Transform _i = grid[i].gameObject.GetComponent<RectTransform>();
                //创建一个物品对象
                GameObject go = (GameObject)Instantiate(_Prefab);
                //把创建的物品对象添加到格子下
                go.transform.SetParent(_i);
                go.SetActive(true);

                go.transform.localScale *= 0.8f;
                //调整物体缩放

                //调整物品的位置位于格子中间
                go.transform.localPosition = Vector3.zero;
                break;
            }


        }
    }
}
