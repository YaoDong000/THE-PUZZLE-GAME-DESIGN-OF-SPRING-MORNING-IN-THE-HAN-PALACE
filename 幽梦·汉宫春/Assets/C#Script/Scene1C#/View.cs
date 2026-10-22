using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    public GameObject Scene1;
    public GameObject Scene2;
    public GameObject Scene3;
    public GameObject SceneMain;

    public void Click1()
    {
        Scene1.SetActive(true);
        SceneMain.SetActive(false);
    }
    public void Click2()
    {
        Scene2.SetActive(true);
        SceneMain.SetActive(false);
    }
    public void Click3()
    {
        Scene3.SetActive(true);
        SceneMain.SetActive(false);
        Scene2.SetActive(false);
        Scene1.SetActive(false);
    }
    public void Click4()
    {
        Scene3.SetActive(false);
        Scene2.SetActive(true);
    }
}
