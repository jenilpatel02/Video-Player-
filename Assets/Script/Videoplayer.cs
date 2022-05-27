using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Videoplayer : MonoBehaviour
{
    public AudioSource sound;
    public Slider audiovolume;
    public VideoPlayer video;
    public VideoClip videoclip;
    public InputField urlText;
    public bool isPause;
    bool isMute;
    bool isvolume;

    public void activeurl()
    {
        video.url = urlText.text;
    }
    public void _audio()
    {
        sound.volume = audiovolume.value;
    }
    void Start()
    {
        video.clip = videoclip;
        isPause = false;
    }
    public void muteUnmutetoggle()
    {
        
        sound.mute = !sound.mute;
    }
      
    
    public void PlayPausetoggle()
    {
        if (isPause)
        {
            video.Play();
            isPause = false;
            Debug.Log("Play");
        }
        else
        {
            video.Pause();
            isPause = true;
            Debug.Log("pause");
        }
    }
    public void SkipNext()
    {
        video.StepForward();
    }
    public void Stop()
    {
        video.Stop();
    }
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayPausetoggle();
        } 
        if(Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            ;
            if (sound.volume != 1)
            {
                sound.volume += 0.2f;
                Debug.Log("Volume :" + sound.volume);
                audiovolume.value = sound.volume;
            }
        }
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
           
            if(sound.volume != 0)
            {
                sound.volume -= 0.2f;
                Debug.Log("Volume :" + sound.volume);
                audiovolume.value = sound.volume;
            }
        }
    }

   
}
