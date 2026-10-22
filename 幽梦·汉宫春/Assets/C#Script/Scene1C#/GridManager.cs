using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
   
    // Start is called before the first frame update
    public List<GameObject> grid;//格子列表，用来存储所有物品
    public GameObject grass,key,fan,bamboo,cup,flower,charm,pray;//物品对象，把prefab添加到这里

    public GameObject ButtonGrass;
    public GameObject ButtonKey;
    public GameObject ButtonFan;
    public GameObject ButtonBamboo;
    public GameObject ButtonCup;
    public GameObject ButtonFlower;
    public GameObject ButtonCharm;
    public GameObject ButtonPray;


    public void ClickGrass()
    {
        AddItem(grass);
        //调用添加物品的方法
        ButtonGrass.SetActive(false);

    }

    public void ClickKey()
    {
        AddItem(key);
        //调用添加物品的方法
        ButtonKey.SetActive(false);

    }

    public void ClickFan()
    {
        AddItem(fan);
        //调用添加物品的方法
        ButtonFan.SetActive(false);

    }

    public void ClickBamboo()
    {
        AddItem(bamboo);
        //调用添加物品的方法
        ButtonBamboo.SetActive(false);

    }
    public void ClickCup()
    {
        AddItem(cup);
        //调用添加物品的方法
        ButtonCup.SetActive(false);

    }

    public void ClickFlower()
    {
        AddItem(flower);
        //调用添加物品的方法
        ButtonFlower.SetActive(false);

    }
    public void ClickCharm()
    {
        AddItem(charm);
        //调用添加物品的方法
        ButtonCharm.SetActive(false);

    }

    public void ClickPray()
    {
        AddItem(pray);
        //调用添加物品的方法
        ButtonPray.SetActive(false);

    }


    public void AddItem(GameObject _Prefab)
    //查找每个格子，寻找空格子的物体
    {
       
        for (int i = 0; i < grid.Count; i++) {
            //通过查找名字来寻找物体，判断格子内是否有物品存在
           
            int isHaving = grid[i].transform.GetComponentsInChildren<Transform>(true).Length;
           
            //如果当前格子有物品存在
            if (isHaving>1)
                continue;
            else if (isHaving<=1)
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
