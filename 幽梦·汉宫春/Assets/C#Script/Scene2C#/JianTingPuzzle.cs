using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JianTingPuzzle : MonoBehaviour
{
    public float Angel1, Angel2, Angel3, Angel4, Angel5, Angel6, Angel7, Angel8, Angel9;
    public GameObject Image1, Image2, Image3, Image4, Image5, Image6, Image7, Image8, Image9;
    private Animation ani;
    
    public void CheckPuzzle()
    {

        Angel1 = Image1.GetComponent<PicturePuzzle>().AngelLast;
        Angel2 = Image2.GetComponent<PicturePuzzle>().AngelLast;
        Angel3 = Image3.GetComponent<PicturePuzzle>().AngelLast;
        Angel4 = Image4.GetComponent<PicturePuzzle>().AngelLast;
        Angel5 = Image5.GetComponent<PicturePuzzle>().AngelLast;
        Angel6 = Image6.GetComponent<PicturePuzzle>().AngelLast;
        Angel7 = Image7.GetComponent<PicturePuzzle>().AngelLast;
        Angel8 = Image8.GetComponent<PicturePuzzle>().AngelLast;
        Angel9 = Image9.GetComponent<PicturePuzzle>().AngelLast;

        //标定A的值等于AngelLast
        if (Angel1 == 0.0 && Angel2 == 0.0 && Angel3 == 0.0 && Angel4 == 0.0
            && Angel5 == 0.0 && Angel6 == 0.0 && Angel7 == 0.0 && Angel8 == 0.0
            && Angel9 == 0.0)
        {
            Debug.Log("角度正确");
            ani = this.GetComponent<Animation>();
            ani.Play("PuzzleAnim");
            //this.gameObject.SetActive(false);
            

        }
        
    }
}
