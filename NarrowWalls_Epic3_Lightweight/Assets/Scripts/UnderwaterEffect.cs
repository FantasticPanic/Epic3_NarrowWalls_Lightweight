﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode, ImageEffectAllowedInSceneView]
public class UnderwaterEffect : MonoBehaviour
{
    public Material _mat;

    [Range(0.001f, 0.1f)]
    public float _pixelOffset;
    [Range(0.1f, 20f)]
    public float _noiseScale;
    [Range(0.1f, 20f)]
    public float _noiseFrequency;
    [Range(0.1f, 30f)]
    public float _noiseSpeed;


    public float _depthStart;
    public float _depthDistance;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _mat.SetFloat("_noiseFrequency", _noiseFrequency);
        _mat.SetFloat("_noiseSpeed", _noiseSpeed);
        _mat.SetFloat("_noiseScale", _noiseScale);
        _mat.SetFloat("_noiseOffset", _pixelOffset);
        _mat.SetFloat("_DepthStart", _depthStart);
        _mat.SetFloat("_DepthDistance", _depthDistance);



    }


    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, _mat);

    }
}
