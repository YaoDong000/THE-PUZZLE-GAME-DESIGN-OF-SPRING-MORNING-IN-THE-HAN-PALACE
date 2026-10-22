using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeSet : MonoBehaviour
{
    public GameObject SettingImage,Slider,Slider2;
    public Sprite Setting, Help;
    // Start is called before the first frame update
    void Start()
    {
        SettingImage.SetActive(false);
        SettingImage.GetComponent<Image>().sprite = Setting;
    }
    public void OnClickSettingButton()
    {
        SettingImage.SetActive(true);
    }
    public void OnClickHelp()
    {
        SettingImage.GetComponent<Image>().sprite = Help;
        Slider.SetActive(false);
        Slider2.SetActive(false);
    }
    public void OnClickSetting()
    {
        SettingImage.GetComponent<Image>().sprite = Setting;
        Slider.SetActive(true);
        Slider2.SetActive(true);
    }
    public void ClickBackButton()
    {
        SettingImage.SetActive(false);
    }
}
