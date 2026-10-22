using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimScript : MonoBehaviour
{
    private Animation ani;
    void Start()
    {
        ani = this.GetComponent<Animation>();
        ani.Play("Scene1MainMove");
    }

}
