using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMain : MonoBehaviour
{
    public GameObject Scene1;
    public GameObject Scene2;
    public GameObject Scene3;
    public GameObject Scene4;
    public GameObject SceneMain,Table;
    public GameObject BookAndCharm;

    public void Click1()
    {
        Scene1.SetActive(false);
        SceneMain.SetActive(true);

    }
    public void Click2()
    {
        Scene2.SetActive(false);
        
        SceneMain.SetActive(true);
    }

    public void Click3()
    {
        Scene3.SetActive(false);
        Scene4.SetActive(false);
        Scene2.SetActive(true);
    }

    public void Click4()
    { 
        Scene4.SetActive(true);
        Scene3.SetActive(false);
    }
    public void ClickOnTable()
    {
        BookAndCharm.SetActive(true);
        Table.SetActive(false);

    }
    public void BackToTable()
    {
        BookAndCharm.SetActive(false);
        Table.SetActive(true);

    }

}
