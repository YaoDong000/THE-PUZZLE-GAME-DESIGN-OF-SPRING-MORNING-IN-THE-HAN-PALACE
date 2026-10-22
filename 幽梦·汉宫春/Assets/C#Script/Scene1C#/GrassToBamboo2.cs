using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrassToBamboo2 : MonoBehaviour
{
    public GameObject Bamboo;
    public GameObject FlowerNull, Flower3Mid;
    //public GameObject SceneATable;
    private GameObject b;
    public GameObject PingFengLast;
    public GameObject Password3;
    public GameObject WaterAnim;
    public GameObject Flower3;
    public GameObject TargetBlack;
    public GameObject WhiteImage;
    public GameObject Charm;
    public GameObject CharmIn;
    public GameObject CharmBoxOn;
    public GameObject Table;
    public GameObject Pray3;
    public GameObject Smoke;
    public GameObject SceneADoor;
    public GameObject SceneAMain;
    public GameObject ChaneSceneButton;
    public Sprite GoK;



    //声明花朵图片
    public Sprite FlowerImage,Tablelast, SceneADoorLast,SceneAMainLast;
    //声明动画
    private Animation ani,ani2;
    
    private Animation ani3;
    //声明搭载动画的物体
    public GameObject SceneBPingFeng;




    private void Start()
    {
        Charm.SetActive(false);
        Password3.SetActive(false);
        Bamboo.SetActive(false);
        CharmIn.SetActive(false);
        Pray3.SetActive(false);
        Smoke.SetActive(false);
        ChaneSceneButton.SetActive(false);
    }

    public void onClickBamboo()
    {
        //Instantiate(Bamboo);
        //GameObject a = Instantiate(Bamboo, transform.position, Quaternion.identity);//实例化物体
        if (GrassToBamboo1.Bam == 4)//调用全局变量
        {
            Bamboo.SetActive(true);
            b = GameObject.Find("PrefabGrass(Clone)");

            GameObject K = b.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(b);
            GrassToBamboo1.Bam = 0;
            

        }
        
        //a.transform.parent = SceneATable.transform;//把实例化的物体放到父物体SceneATable之下
    }

    public void onClickPingFeng()
    {
        //Instantiate(Bamboo);
        //GameObject a = Instantiate(Bamboo, transform.position, Quaternion.identity);//实例化物体
        if (GrassToBamboo1.Bam == 5)//调用全局变量
        {
            b = GameObject.Find("Bamboo(Clone)");//查找背包的的竹枝

            GameObject K = b.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(b);//销毁竹枝（因为用掉了嘛）
            GrassToBamboo1.Bam = 0;//重新设定Bam的数值
            PingFengLast.SetActive(true);
            ani = SceneBPingFeng.GetComponent<Animation>();
            ani.Play("BamAnim");

        }

        //a.transform.parent = SceneATable.transform;//把实例化的物体放到父物体SceneATable之下
    }
    public void onClickCup()
    {
       
        if (GrassToBamboo1.Bam == 6)//调用全局变量
        {
            b = GameObject.Find("Cup(Clone)");//查找背包的的竹枝

            GameObject K = b.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(b);//销毁杯子（因为用掉了嘛）
            
            
            WaterAnim.SetActive(true);
            //ani2 = WaterAnim.GetComponent<Animation>();
            //ani2.Play("WaterAnim");
            Animator ani2 = WaterAnim.GetComponent<Animator>();
            ani2.SetInteger("AnimState", 1);

            //Password3.SetActive(true);
            Invoke("PasswordShow", 0.8f);
           
            GrassToBamboo1.Bam = 0;//重新设定Bam的数值



        }

    }
    public void PasswordShow()
    {
        Password3.SetActive(true);
    }

    public void onClickFlower()
    {

        if (GrassToBamboo1.Bam == 7)//调用全局变量
        {
            b = GameObject.Find("Flower3(Clone)");//查找背包的的竹枝

            GameObject K = b.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(b);//销毁背包中的花朵（因为用掉了嘛）
            GrassToBamboo1.Bam = 0;//重新设定Bam的数值
            Flower3.GetComponent<Image>().sprite = FlowerImage;
            FlowerNull.SetActive(false);
            Flower3Mid.SetActive(true);

        }

    }
    public void onClickBlackChess()
    {

        if (GrassToBamboo1.Bam == 8)//调用全局变量
        {
            b = GameObject.Find("Black");//查找黑棋

            Destroy(b);//销毁黑棋
            GrassToBamboo1.Bam = 0;//重新设定Bam的数值
            TargetBlack.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            WhiteImage.SetActive(false);
            Charm.SetActive(true);
        }

    }

    public void OnClickCharm()
    {

        if (GrassToBamboo1.Bam == 9)//调用全局变量
        {
            b = GameObject.Find("Charm 1(Clone)");//查找符咒

            GameObject K = b.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(b);//销毁符咒
            GrassToBamboo1.Bam = 0;//重新设定Bam的数值
            CharmIn.SetActive(true);
            ani = CharmBoxOn.GetComponent<Animation>();
            ani.Play("CharmBoxOnAnim");
            Table.GetComponent<Image>().sprite = Tablelast;//切换图片

            ani2 = CharmIn.GetComponent<Animation>();
            ani2.Play("CharmIn");
        }

    }

    public void OnClickPray()
    {

        if (GrassToBamboo1.Bam == 10)//调用全局变量
        {
            b = GameObject.Find("Pray(Clone)");//查找香

            GameObject K = b.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;

            Destroy(b);//销毁香
            GrassToBamboo1.Bam = 0;//重新设定Bam的数值
            Pray3.SetActive(true);
            ani2 = Pray3.GetComponent<Animation>();
            ani2.Play("Pray3Anim");




        }

    }
    public void OnClickSmoke()
    {

        if (GrassToBamboo1.Bam == 11)//调用全局变量
        {
            b = GameObject.Find("Fan(Clone)");//查找扇子

            GameObject K = b.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;
            

            Destroy(b);//销毁扇子
            GrassToBamboo1.Bam = 0;//重新设定Bam的数值
            
            Smoke.SetActive(true);
            ani = Smoke.GetComponent<Animation>();
            ani.Play("SmokeAnim");


        }

    }
    public void OnClickKey()
    {

        if (GrassToBamboo1.Bam == 12)//调用全局变量
        {
            b = GameObject.Find("key(Clone)");//查找钥匙

            GameObject K = b.transform.parent.gameObject;
            K.GetComponent<Image>().sprite = GoK;
            

            Destroy(b);//销毁钥匙
            GrassToBamboo1.Bam = 0;//重新设定Bam的数值
            SceneADoor.GetComponent<Image>().sprite = SceneADoorLast;//切换图片
            SceneAMain.GetComponent<Image>().sprite = SceneAMainLast;//切换图片
            ChaneSceneButton.SetActive(true);

            

        }

    }

   

}
