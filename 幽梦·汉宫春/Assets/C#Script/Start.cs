using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class Start : MonoBehaviour
{
    public GameObject Video1, Video2;

    private void Awake()
    {
        Video1.SetActive(true);
        Video2.SetActive(false);

    }
    public void OnClickStartButton()
    {

        Video1.SetActive(false);
        Video2.SetActive(true);

    }
  
    public void OnClickScene1()
    {

        SceneManager.LoadScene("SampleScene");

    }
    public void OnClickScene2()
    {

        SceneManager.LoadScene("SampleScene2");

    }
    



}
