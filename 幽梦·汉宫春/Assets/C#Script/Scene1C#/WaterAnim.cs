using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAnim : MonoBehaviour
{
    private Animation ani;
    void Start()
    {
        ani = this.GetComponent<Animation>();
        ani.Play("WaterAnim");
    }
}
