using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;
 public class SliderScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public VideoPlayer videotrack;
    Slider track;
    bool Slide = false;

    public void OnPointerDown(PointerEventData a)
    {
        Slide = true;
    }

    public void OnPointerUp(PointerEventData a)
    {
        float frame = (float)track.value * (float)videotrack.frameCount;
        videotrack.frame = (long)frame;
        Slide = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        track=GetComponent<Slider>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (!Slide && videotrack.isPlaying)
        {
            track.value =(float) videotrack.frame / (float)videotrack.frameCount;
        }
    }
}
