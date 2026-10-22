using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessTip : MonoBehaviour
{
    public GameObject ChessTipSmall;
    public GameObject ChessTipLarge;

    public void OnClick()
    {
        ChessTipLarge.SetActive(true);
        ChessTipSmall.SetActive(false);
    }
    public void OnClickBack()
    {
        ChessTipLarge.SetActive(false);
        ChessTipSmall.SetActive(true);
    }
}
