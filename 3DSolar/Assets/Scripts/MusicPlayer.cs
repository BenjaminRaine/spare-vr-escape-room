using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public int currentSong = 0;

    [SerializeField]
    private AudioSource[] tracks;

    public void SwitchSong()
    {
        currentSong = (currentSong + 1) % tracks.Length;
        tracks[currentSong].Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!tracks[currentSong].isPlaying)
        {
            SwitchSong();
        }
    }


}
