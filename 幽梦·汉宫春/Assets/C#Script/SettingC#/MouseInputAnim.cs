using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputAnim : MonoBehaviour
{
    public Transform parent;
    public GameObject effect;
    [Range(0, 5.0f)]
    public float desTime = 1.0f;
    Vector2 point;
    public Canvas UICanvas; //你所使用的UICanvas


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //将鼠标点击的屏幕坐标转换为UI坐标，最后一个输出参数为转换的点
            RectTransformUtility.ScreenPointToLocalPointInRectangle(UICanvas.transform as RectTransform,
Input.mousePosition, UICanvas.worldCamera, out point);

            GameObject go = Instantiate(effect, parent);
            go.GetComponent<RectTransform>().anchoredPosition = point;
            Destroy(go, desTime);
        }
    }
}
