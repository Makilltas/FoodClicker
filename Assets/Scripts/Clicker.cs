using UnityEngine;
using DG.Tweening;

public class Clicker : MonoBehaviour
{
    [Header("Animation")]
<<<<<<< HEAD

    public float scale = 1.2f;

    public float duration = 0.5f;
    public Ease ease = Ease.OutElastic;
    [Header("Audio")]
    public AudioClip clickSound;


    [HideInInspector]public int clicks = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private AudioSource audioSource;
=======
    public float scale = 1.2f;
    public float duration = 0.5f;
    public Ease ease = Ease.OutElastic;

    [Header("Audio")]
    public AudioClip clickSound;

    [HideInInspector]public int clicks = 0;
    private AudioSource audioSource;

    private void Start() 
    {
        audioSource = GetComponent<AudioSource>();
    }
>>>>>>> 740eb179779cb4049aed8074feb694bb38b60e27

    private void OnMouseDown() 
    {
        clicks++;
        UiManager.instance.UpdateClicks(clicks);

<<<<<<< HEAD

        audioSource.pitch = Random.Range(0.9f, 1.1f);
        audioSource.PlayOneShot(clickSound);


        transform
            .DOScale(1, duration)
            .ChangeStartValue(scale * Vector3.one
            ).SetEase(ease);
            //.SetLoops(2, LoopType.Yoyo);
=======
        audioSource.pitch = Random.Range(0.9f, 1.1f);
        audioSource.PlayOneShot(clickSound);

        transform
            .DOScale(1, duration)
            .ChangeStartValue(scale * Vector3.one)
            .SetEase(ease);
            //.SetLoops(2, LoopType.Yoyo);3
>>>>>>> 740eb179779cb4049aed8074feb694bb38b60e27
    }
}
