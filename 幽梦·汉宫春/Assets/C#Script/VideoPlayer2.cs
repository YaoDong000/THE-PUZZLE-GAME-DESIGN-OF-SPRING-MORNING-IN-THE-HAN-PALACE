using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlayer2 : MonoBehaviour
{
    //定义参数获取VideoPlayer组件和RawImage组件
    public GameObject RawImage, RawImageLast;
    private VideoPlayer videoPlayer;
    private RawImage rawImage;
    public double time;
    public double currentTime;
    public GameObject AudioSource;

    // Use this for initialization

    void Start()
    {

        RawImage.SetActive(false);
        RawImageLast.SetActive(false);

    }

    public void OnClickLeave()
    {
        RawImage.SetActive(true);
        //获取场景中对应的组件
        videoPlayer = this.GetComponent<VideoPlayer>();

        rawImage = this.GetComponent<RawImage>();
        //获取影片的时长
        time = rawImage.GetComponent<VideoPlayer>().clip.length;
    }

    // Update is called once per frame

    void Update()
    {

        //如果videoPlayer没有对应的视频texture，则返回

        if (videoPlayer.texture == null)
        {

            return;

        }

        //把VideoPlayerd的视频渲染到UGUI的RawImage

        rawImage.texture = videoPlayer.texture;

        currentTime += Time.deltaTime;
        if (currentTime >= time)
        {
            Debug.Log("播放完毕！！！");
            RawImageLast.SetActive(true);
            AudioSource.SetActive(false);
        }

    }


}
