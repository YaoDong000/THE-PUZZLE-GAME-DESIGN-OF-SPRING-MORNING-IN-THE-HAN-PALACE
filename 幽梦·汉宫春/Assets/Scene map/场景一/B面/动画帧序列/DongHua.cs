using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DongHua : MonoBehaviour
{
    public Sprite[] Sprites;
    public float speed;
    private SpriteRenderer spriterenderer;

    public void ClickCupDongHua()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        int index = (int)(Time.time * speed) % Sprites.Length;
        spriterenderer.sprite = Sprites[index];

    }

}
