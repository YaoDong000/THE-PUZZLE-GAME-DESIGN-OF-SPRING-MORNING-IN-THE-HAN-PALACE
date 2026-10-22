using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicturePuzzle : MonoBehaviour
{
    public GameObject Image;
    float[] myArray = { 0, 90, 180, 270 };
    public float AngelLast;
    

    void Start()
    {
        float element = myArray[Random.Range(0, myArray.Length)];//从数组中选择一个随机项
        Image.transform.localEulerAngles = new Vector3(0, 0, element);
        //Image.transform.Rotate(0, 0, element, Space.World);//本物体的角度等于随机物体角度
        AngelLast = Image.transform.localEulerAngles.z;
    }
    


    public void ClickImage()
    {
        
        float a = Image.transform.localEulerAngles.z;
        if (a < 270)
        {
            
            //Image.transform.Rotate(0, 0, 90, Space.World);
            Image.transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,
                transform.localEulerAngles.y,
                transform.localEulerAngles.z + 90);
        }
        else
        {
            Image.transform.localEulerAngles = new Vector3(0, 0, 0);

        }
        AngelLast = Image.transform.localEulerAngles.z;
    }
   

    
}
