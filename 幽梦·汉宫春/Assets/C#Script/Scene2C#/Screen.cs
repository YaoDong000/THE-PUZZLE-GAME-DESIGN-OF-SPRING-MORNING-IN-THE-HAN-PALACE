using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screen : MonoBehaviour
{
    public GameObject ScreenPicture,ScreenAll,tipimage;
    private Animation ani;
    internal static float width;

    public static float height { get; internal set; }

    private void Start()
    {
        ScreenAll.SetActive(false);
        ani = ScreenPicture.GetComponent<Animation>();
        ani.Play("ScreenAnim");
        
    }
    public void OnClickScreen()
    {
        ScreenAll.SetActive(true);
        tipimage.SetActive(false);
    }
    public void BackToScreen()
    {
        ScreenAll.SetActive(false);
        tipimage.SetActive(true);
    }
   
}
