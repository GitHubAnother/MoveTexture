/*
作者名称:YHB

脚本作用:用来播放视屏

建立时间:2016.8.2.19.17
*/

using UnityEngine;
using System.Collections;
using System;

public class Movie : MonoBehaviour
{
    #region 字段
    public MovieTexture movieTexture;

    private Renderer _renderer;
    private AudioSource _audioSource;
    #endregion

    void Awake()
    {
        _renderer = this.GetComponent<Renderer>();
        _audioSource = this.GetComponent<AudioSource>();
    }
    void Start()
    {
        _renderer.material.mainTexture = movieTexture;
        _audioSource.clip = movieTexture.audioClip;
    }

    public void Play()
    {
        movieTexture.Play();
        _audioSource.Play();
    }

    public void Pause()
    {
        movieTexture.Pause();
    }

    public void Stop()
    {
        movieTexture.Stop();
    }
}
