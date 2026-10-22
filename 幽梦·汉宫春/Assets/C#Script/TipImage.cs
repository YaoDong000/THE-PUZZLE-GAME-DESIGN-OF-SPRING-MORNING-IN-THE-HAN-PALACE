using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipImage : MonoBehaviour
{
    GameObject SceneTip;
    public Transform[] Tip;
   
    public void OnClickTip(string name)
    {
       
        SceneTip = GameObject.FindWithTag("SceneTip");
        Tip = SceneTip.GetComponentsInChildren<Transform>();
        
        foreach(var child in Tip)
        {
            Debug.Log(child.name);
            if (child.name == name)
            {
                child.GetComponent<Image>().enabled = true;
                child.GetComponent<Button>().enabled = true;
            }
        }
    }

    
}
