using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password3Anim : MonoBehaviour
{
    private Animation ani;
    void Start()
    {
        ani = this.GetComponent<Animation>();
        ani.Play("Password3");
    }
}
