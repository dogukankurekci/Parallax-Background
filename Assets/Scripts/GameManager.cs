using System;
using System.Collections;
using System.Collections.Generic;
using StarterKit.Base;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //TODO refactor
    [SerializeField]
    private Player player;
    [SerializeField]
    private ParallaxBackground parallaxBackground;

    [SerializeField]
    private BaseObject[] baseObjects;

    private void Awake()
    {
        CallBaseObjectAwakes();
    }

    private void Start()
    {
        CallBaseObjectStarts();
    }

    private void Update()
    {
        CallBaseObjectUpdates();
    }

    private void FixedUpdate()
    {
        CallBaseObjecFixedUpdates();
    }

    private void LateUpdate()
    {
        CallBaseObjectLateUpdates();
    }

    private void OnDestroy()
    {
        CallBaseObjectDestroys();
    }

    private void CallBaseObjectAwakes()
    {
        for (int i = 0; i < baseObjects.Length; i++)
        {
            baseObjects[i].BaseObjectAwake();
        }
    }

    private void CallBaseObjectStarts()
    {
        for (int i = 0; i < baseObjects.Length; i++)
        {
            baseObjects[i].BaseObjectStart();
        }
    }

    private void CallBaseObjectUpdates()
    {
        for (int i = 0; i < baseObjects.Length; i++)
        {
            baseObjects[i].BaseObjectUpdate();
        }
    }
    private void CallBaseObjecFixedUpdates()
    {
        for (int i = 0; i < baseObjects.Length; i++)
        {
            baseObjects[i].BaseObjectFixedUpdate();
        }
    }

    private void CallBaseObjectLateUpdates()
    {
        for (int i = 0; i < baseObjects.Length; i++)
        {
            baseObjects[i].BaseObjectLateUpdate();
        }
    }

    private void CallBaseObjectDestroys()
    {
        for (int i = 0; i < baseObjects.Length; i++)
        {
            baseObjects[i].BaseObjectDestroy();
        }
    }
}
