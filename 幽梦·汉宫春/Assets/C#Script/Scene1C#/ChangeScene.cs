using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public GameObject SceneLeft;
    public GameObject SceneRight;
    public GameObject SceneNow;
    public GameObject SceneA;

    private void Start()
    {
        SceneA.SetActive(false);
    }
    public void LeftButton()
    {
        SceneLeft.SetActive(true);
        SceneNow.SetActive(false);
    }
    public void RightButton()
    {
        SceneRight.SetActive(true);
        SceneNow.SetActive(false);
    }
}
