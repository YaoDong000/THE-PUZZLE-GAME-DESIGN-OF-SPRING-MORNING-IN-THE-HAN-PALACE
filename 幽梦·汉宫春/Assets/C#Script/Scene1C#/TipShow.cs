using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipShow : MonoBehaviour
{
    public GameObject TipImage;
    private void Start()
    {
        TipImage.SetActive(false);
    }
    public void OnClickTip()
    {
        TipImage.SetActive(true);
    }
    public void OnClickTipImage()
    {
        TipImage.SetActive(false);
    }


}
