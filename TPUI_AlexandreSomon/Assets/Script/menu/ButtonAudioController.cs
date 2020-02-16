using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAudioController : MonoBehaviour
{
    [SerializeField] private Button SoundButton;
    private Image actualAudioSprite;
    private AudioSource audio;
    private Sprite SoundOn, SoundOff;
    private bool AudioPaused = false;
    private void Awake()
    {
        //Par défaut l'audio est activé
        actualAudioSprite = SoundButton.GetComponent<Image>();
        audio = GetComponent<AudioSource>();
        SoundOn = Resources.Load<Sprite>("Sprites/SoundOn"); 
        SoundOff = Resources.Load<Sprite>("Sprites/SoundOff"); 
    }

    public void SoundButtonActivate(){
        if(AudioPaused == false){
            audio.Pause();
            actualAudioSprite.sprite = SoundOff;
            AudioPaused = true;
        }else{
            audio.UnPause();
            actualAudioSprite.sprite = SoundOn;
            AudioPaused = false;
        }
    }
}
