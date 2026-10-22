using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabAnim : MonoBehaviour
{
    private Animation ani;
    void Start()
    {
        ani = this.GetComponent<Animation>();
        ani.Play("PrefabAnim");
    }
}
