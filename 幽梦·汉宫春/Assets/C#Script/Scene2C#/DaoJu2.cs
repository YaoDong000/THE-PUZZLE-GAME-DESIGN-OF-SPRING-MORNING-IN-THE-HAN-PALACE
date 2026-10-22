using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DaoJu2 : MonoBehaviour
{
    public GameObject Seed, ScenePeacock,Cylinder,YellowColor,BlueColor,YuRuYi,Tip, Cylinder2;
    public GameObject YellowColorButton, BlueColorButton, SceneBWaterAnim,
        CylinderIn1, CylinderIn2, CylinderIn3, SceneELock, SceneEMain,Leaf1,Leaf2,Leaf3, LeaveButton;
    public Sprite Peacock1,Peacock2, YuRuYiCrImage, SceneEOpen,GoK;
    private GameObject c;
    private Animation AniYu;
    int DoorValue = 0;
    int LeafValue = 0;
    private void Start()
    {
        Cylinder.SetActive(false);
        Seed.SetActive(false);
        YellowColor.SetActive(false);
        BlueColor.SetActive(false);
        YuRuYi.SetActive(false);
        Cylinder2.SetActive(false);
        LeaveButton.SetActive(false);
    }
    public void onClickPeacock()
    {
        
        if (DaoJu1.DaoJuNum == 1)//调用全局变量
        {
            Seed.SetActive(true);//种子出现
            c = GameObject.Find("Seed(Clone)");

            GameObject K = c.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(c);
            Invoke("QieHuanPeacock2", 2f);
            Invoke("QieHuanPeacock1", 3f);
            DaoJu1.DaoJuNum = 0;


        }
    }
    void QieHuanPeacock2()
    {
        ScenePeacock.GetComponent<Image>().sprite = Peacock2;//切换孔雀贴图
        Seed.SetActive(false);
        Debug.Log("换图成功！");
    }
    void QieHuanPeacock1()
    {
        ScenePeacock.GetComponent<Image>().sprite = Peacock1;//切换孔雀贴图
        Cylinder.SetActive(true);

    }

    public void onClickYellowColorButton()
    {

        if (DaoJu1.DaoJuNum == 2)//调用全局变量
        {
            YellowColor.SetActive(true);
            YellowColorButton.SetActive(false);
            c = GameObject.Find("Color1(Clone)");

            GameObject K = c.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(c);
            DaoJu1.DaoJuNum = 0;
            Debug.Log("加颜料2！");



        }
    }

    public void onClickBlueColorButton()
    {

        if (DaoJu1.DaoJuNum == 3)//调用全局变量
        {
            BlueColor.SetActive(true);
            BlueColorButton.SetActive(false);
            c = GameObject.Find("BlueColor(Clone)");

            GameObject K = c.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(c);
            DaoJu1.DaoJuNum = 0;
            Debug.Log("加颜料3！");


        }
    }

    public void onClickTip()
    {

        if (DaoJu1.DaoJuNum == 4)//调用全局变量
        {
            YuRuYi.SetActive(true);
            Tip.SetActive(false);
            c = GameObject.Find("YuRuYi(Clone)");

            GameObject K = c.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(c);
            Invoke("YuRuYiCrack", 1f);
            DaoJu1.DaoJuNum = 0;
            Debug.Log("出现玉如意！");


        }
    }
    public void YuRuYiCrack()
    {
       YuRuYi.GetComponent<Image>().sprite = YuRuYiCrImage;
       Cylinder2.SetActive(true);
       AniYu = YuRuYi.GetComponent<Animation>();
       AniYu.Play("YuRuYiAnim");

    }
    public void onClickLock1()
    {

        if (DaoJu1.DaoJuNum == 5)//调用全局变量
        {

            CylinderIn1.SetActive(true);
            c = GameObject.Find("Cylinder1(Clone)");

            GameObject K = c.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(c);
            DaoJu1.DaoJuNum = 0;
            Debug.Log("加上锁块1！");
            DoorValue++;

        }

        if (DoorValue == 3)
        {
            SceneEMain.GetComponent<Image>().sprite = SceneEOpen;
            SceneEMain.SetActive(true);
            LeaveButton.SetActive(true);
            SceneELock.SetActive(false);
        }
    }
    public void onClickLock2()
    {

        if (DaoJu1.DaoJuNum == 6)//调用全局变量
        {

            CylinderIn2.SetActive(true);
            c = GameObject.Find("Cylinder2(Clone)");

            GameObject K = c.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(c);
            DaoJu1.DaoJuNum = 0;
            Debug.Log("加上锁块2！");

            DoorValue++;
        }

        if (DoorValue == 3)
        {
            SceneEMain.GetComponent<Image>().sprite = SceneEOpen;
            SceneEMain.SetActive(true);
            LeaveButton.SetActive(true);
            SceneELock.SetActive(false);
        }
    }
    public void onClickLock3()
    {

        if (DaoJu1.DaoJuNum == 7)//调用全局变量
        {

            CylinderIn3.SetActive(true);
            c = GameObject.Find("Cylinder3(Clone)");

            GameObject K = c.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(c);
            DaoJu1.DaoJuNum = 0;
            Debug.Log("加上锁块3！");

            DoorValue++;
        }
        if(DoorValue == 3)
        {
            SceneEMain.GetComponent<Image>().sprite = SceneEOpen;
            SceneEMain.SetActive(true);
            LeaveButton.SetActive(true);
            SceneELock.SetActive(false);
        }
    }

    public void onClickLeaf1()
    {

        if (DaoJu1.DaoJuNum == 8)//调用全局变量
        {

            Leaf1.SetActive(true);
            c = GameObject.Find("Leaf1(Clone)");

            GameObject K = c.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(c);
            DaoJu1.DaoJuNum = 0;
            LeafValue++;
        }

        if (LeafValue == 3)
        {
            SceneBWaterAnim.SetActive(true);
        }

    }
    public void onClickLeaf2()
    {

        if (DaoJu1.DaoJuNum == 9)//调用全局变量
        {

            Leaf2.SetActive(true);
            c = GameObject.Find("Leaf2(Clone)");

            GameObject K = c.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(c);
            DaoJu1.DaoJuNum = 0;
            LeafValue++;
        }
        if (LeafValue == 3)
        {
            SceneBWaterAnim.SetActive(true);
        }

    }
    public void onClickLeaf3()
    {

        if (DaoJu1.DaoJuNum == 10)//调用全局变量
        {

            Leaf3.SetActive(true);
            c = GameObject.Find("Leaf3(Clone)");

            GameObject K = c.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(c);
            DaoJu1.DaoJuNum = 0;
            LeafValue++;
        }
        if (LeafValue == 3)
        {
            SceneBWaterAnim.SetActive(true);
        }
    }

}
