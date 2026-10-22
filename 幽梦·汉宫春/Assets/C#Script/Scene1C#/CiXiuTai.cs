using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CiXiuTai : MonoBehaviour
{
    public GameObject Flower1Up;
    public GameObject Flower1Mid;
    public GameObject Flower1Down;

    public GameObject Flower2Up;
    public GameObject Flower2Mid;
    public GameObject Flower2Down;

    public GameObject Flower3Up;
    public GameObject Flower3Mid;
    public GameObject Flower3Down;

    public GameObject Flower4Up;
    public GameObject Flower4Mid;
    public GameObject Flower4Down;

    public GameObject Flower5Up;
    public GameObject Flower5Mid;
    public GameObject Flower5Down;

    public GameObject CiXiu;
    public GameObject CiXiuTaiLast;

    public Sprite Flower1;
    public Sprite Flower2;
    public Sprite Flower3;
    public Sprite Flower3Di;
    public Sprite Flower4;
    public Sprite Flower5;
    public Sprite BlackDot;

    public int t1, t2, t3, t4, t5;

    private void Start()
    {
        Flower1Mid.GetComponent<Image>().sprite = Flower1;
        Flower1Up.GetComponent<Image>().sprite = BlackDot;
        Flower1Down.GetComponent<Image>().sprite = BlackDot;
        t1 = 2;

        Flower2Mid.GetComponent<Image>().sprite = Flower2;
        Flower2Up.GetComponent<Image>().sprite = BlackDot;
        Flower2Down.GetComponent<Image>().sprite = BlackDot;
        t2 = 2;

        Flower3Mid.GetComponent<Image>().sprite = Flower3;
        Flower3Up.GetComponent<Image>().sprite = BlackDot;
        Flower3Down.GetComponent<Image>().sprite = BlackDot;
        t3 = 2;

        Flower4Mid.GetComponent<Image>().sprite = Flower4;
        Flower4Up.GetComponent<Image>().sprite = BlackDot;
        Flower4Down.GetComponent<Image>().sprite = BlackDot;
        t4 = 2;

        Flower5Mid.GetComponent<Image>().sprite = Flower5;
        Flower5Up.GetComponent<Image>().sprite = BlackDot;
        Flower5Down.GetComponent<Image>().sprite = BlackDot;
        t5 = 2;
    }
    //第一组
    public void ClickFlower1Up()
    {
        Flower1Up.GetComponent<Image>().sprite = Flower1;
        Flower1Mid.GetComponent<Image>().sprite = BlackDot;
        Flower1Down.GetComponent<Image>().sprite = BlackDot;
        t1 = 1;
    }
    public void ClickFlower1Mid()
    {
        Flower1Mid.GetComponent<Image>().sprite = Flower1;
        Flower1Up.GetComponent<Image>().sprite = BlackDot;
        Flower1Down.GetComponent<Image>().sprite = BlackDot;
        t1 = 2;
    }
    public void ClickFlower1Down()
    {
        Flower1Down.GetComponent<Image>().sprite = Flower1;
        Flower1Mid.GetComponent<Image>().sprite = BlackDot;
        Flower1Up.GetComponent<Image>().sprite = BlackDot;
        t1 = 3;
    }
    //第二组
    public void ClickFlower2Up()
    {
        Flower2Up.GetComponent<Image>().sprite = Flower2;
        Flower2Mid.GetComponent<Image>().sprite = BlackDot;
        Flower2Down.GetComponent<Image>().sprite = BlackDot;
        t2 = 1;
    }
    public void ClickFlower2Mid()
    {
        Flower2Mid.GetComponent<Image>().sprite = Flower2;
        Flower2Up.GetComponent<Image>().sprite = BlackDot;
        Flower2Down.GetComponent<Image>().sprite = BlackDot;
        t2 = 2;
    }
    public void ClickFlower2Down()
    {
        Flower2Down.GetComponent<Image>().sprite = Flower2;
        Flower2Mid.GetComponent<Image>().sprite = BlackDot;
        Flower2Up.GetComponent<Image>().sprite = BlackDot;
        t2 = 3;
    }

    internal static void SetActive(bool v)
    {
        throw new NotImplementedException();
    }

    //第三组
    public void ClickFlower3Up()
    {
        Flower3Up.GetComponent<Image>().sprite = Flower3;
        Flower3Mid.GetComponent<Image>().sprite = BlackDot;
        Flower3Down.GetComponent<Image>().sprite = BlackDot;
        t3 = 1;
    }
    public void ClickFlower3Mid()
    {
        Flower3Mid.GetComponent<Image>().sprite = Flower3;
        Flower3Up.GetComponent<Image>().sprite = BlackDot;
        Flower3Down.GetComponent<Image>().sprite = BlackDot;
        t3 = 2;
    }
    public void ClickFlower3Down()
    {
        Flower3Down.GetComponent<Image>().sprite = Flower3;
        Flower3Mid.GetComponent<Image>().sprite = BlackDot;
        Flower3Up.GetComponent<Image>().sprite = BlackDot;
        t3 = 3;
    }

    //第四组
    public void ClickFlower4Up()
    {
        Flower4Up.GetComponent<Image>().sprite = Flower4;
        Flower4Mid.GetComponent<Image>().sprite = BlackDot;
        Flower4Down.GetComponent<Image>().sprite = BlackDot;
        t4 = 1;
    }
    public void ClickFlower4Mid()
    {
        Flower4Mid.GetComponent<Image>().sprite = Flower4;
        Flower4Up.GetComponent<Image>().sprite = BlackDot;
        Flower4Down.GetComponent<Image>().sprite = BlackDot;
        t4 = 2;
    }
    public void ClickFlower4Down()
    {
        Flower4Down.GetComponent<Image>().sprite = Flower4;
        Flower4Mid.GetComponent<Image>().sprite = BlackDot;
        Flower4Up.GetComponent<Image>().sprite = BlackDot;
        t4 = 3;
    }

    //第五组
    public void ClickFlower5Up()
    {
        Flower5Up.GetComponent<Image>().sprite = Flower5;
        Flower5Mid.GetComponent<Image>().sprite = BlackDot;
        Flower5Down.GetComponent<Image>().sprite = BlackDot;
        t5 = 1;
    }
    public void ClickFlower5Mid()
    {
        Flower5Mid.GetComponent<Image>().sprite = Flower5;
        Flower5Up.GetComponent<Image>().sprite = BlackDot;
        Flower5Down.GetComponent<Image>().sprite = BlackDot;
        t5 = 2;
    }
    public void ClickFlower5Down()
    {
        Flower5Down.GetComponent<Image>().sprite = Flower5;
        Flower5Mid.GetComponent<Image>().sprite = BlackDot;
        Flower5Up.GetComponent<Image>().sprite = BlackDot;
        t5 = 3;
    }

    private void Update()
    {
        if (t1 == 1 && t2 == 2 && t3 == 1 && t4 == 3 && t5 == 2)
        {
            Debug.Log("顺序正确！");
            //CiXiu.GetComponent<CiXiuTai>().enabled = false;
            CiXiuTaiLast.SetActive(true);
        }
    }
}
