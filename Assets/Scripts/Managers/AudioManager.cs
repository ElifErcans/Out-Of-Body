using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    [SerializeField] private AudioClip arpDO;
    [SerializeField] private AudioClip arpRE;
    [SerializeField] private AudioClip arpMI;
    [SerializeField] private AudioClip arpFA;
    [SerializeField] private AudioClip arpSOL;
    [SerializeField] private AudioClip arpLA;
    public  AudioSource audioSource;
    [SerializeField] AudioSource secondAudioSource;

    [SerializeField] private float defaultSoundVolume = 1;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        SetSoundVolumeToSaveData();
    }

    public void StopAudioSource()
    {
        audioSource.Stop();
    }
    public void CloseSound()
    {
        audioSource.volume = 0;
        secondAudioSource.volume = 0;
        // PlayerPrefs.SetFloat(Names.soundVolume, 0);
    }
    public void OpenSound()
    {
        audioSource.volume = defaultSoundVolume;
        secondAudioSource.volume = defaultSoundVolume;
        // PlayerPrefs.SetFloat(Names.soundVolume, defaultSoundVolume);
    }

    public void PlayArpSounds(AudioClip ses)
    {
        // if (!audioSource.isPlaying)
        audioSource.PlayOneShot(ses);
    }
    public void PlayArpRe()
    {
        // if (!audioSource.isPlaying)
        audioSource.PlayOneShot(arpRE);
    }
    public void PlayArpMi()
    {
        // if (!audioSource.isPlaying)
        audioSource.PlayOneShot(arpMI);
    }
    public void PlayArpFa()
    {
        // if (!audioSource.isPlaying)
        audioSource.PlayOneShot(arpFA);
    }
    public void PlayArpSol()
    {
        // if (!audioSource.isPlaying)
        audioSource.PlayOneShot(arpSOL);
    }
    public void PlayArpLa()
    {
        // if (!audioSource.isPlaying)
        audioSource.PlayOneShot(arpLA);
    }

    private void SetSoundVolumeToSaveData()
    {
        // float savedVolume = PlayerPrefs.GetFloat(Names.soundVolume);
        // audioSource.volume = savedVolume;
        // secondAudioSource.volume = savedVolume;
    }

}
