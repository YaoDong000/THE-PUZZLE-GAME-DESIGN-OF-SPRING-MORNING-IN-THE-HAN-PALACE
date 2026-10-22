using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipImageShow : MonoBehaviour
{
    private void Start()
    {
        this.GetComponent<Image>().enabled = false;
        this.GetComponent<Button>().enabled = false;
    }
    public void ClickTipImage()
    {
        this.GetComponent<Image>().enabled = false;
        this.GetComponent<Button>().enabled = false;
    }

}
