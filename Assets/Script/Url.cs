using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Url : MonoBehaviour
{
    public VideoPlayer video;
    public Text UrlText;

    public void activeurl()
    {
        video.url = UrlText.text;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
