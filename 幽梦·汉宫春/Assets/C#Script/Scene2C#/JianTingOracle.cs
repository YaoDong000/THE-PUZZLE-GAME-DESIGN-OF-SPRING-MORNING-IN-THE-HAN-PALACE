using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JianTingOracle : MonoBehaviour
{
    public int OracleFlag1, OracleFlag2, OracleFlag3, OracleFlag4;
    public GameObject OracleA,OracleB,OracleC,OracleD, Cylinder4;
    private Animation ani;

    private void Start()
    {
        Cylinder4.SetActive(false);
    }
    public void CheckOracle()
    {

        OracleFlag1 = OracleA.GetComponent<ScreenOracle>().Flag;
        OracleFlag2 = OracleB.GetComponent<ScreenOracle>().Flag;
        OracleFlag3 = OracleC.GetComponent<ScreenOracle>().Flag;
        OracleFlag4 = OracleD.GetComponent<ScreenOracle>().Flag;
        //标定A的值等于AngelLast
        if (OracleFlag1 == 1 && OracleFlag2 == 2 && OracleFlag3 == 3 && OracleFlag4 == 4 )
        {
            Debug.Log("刻符正确！");
            Cylinder4.SetActive(true);
            ani = Cylinder4.GetComponent<Animation>();
            ani.Play("Cylinder4Anim");

            Button ButtonA = OracleA.GetComponent<Button>();
            ButtonA.enabled = !ButtonA.enabled;//禁用物体的button组件
            Button ButtonB = OracleB.GetComponent<Button>();
            ButtonB.enabled = !ButtonB.enabled;//禁用物体的button组件
            Button ButtonC = OracleC.GetComponent<Button>();
            ButtonC.enabled = !ButtonC.enabled;//禁用物体的button组件
            Button ButtonD = OracleD.GetComponent<Button>();
            ButtonD.enabled = !ButtonD.enabled;//禁用物体的button组件
            
        }

    }
}
