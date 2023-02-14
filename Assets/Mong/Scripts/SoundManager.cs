using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Header("���� �����")]
    public AudioSource attackSound;
    public AudioSource takeHitSound;
    public AudioSource paintSound;
    [Header("���� ��ü")]
    public AudioSource dragon;
    public AudioSource uptrain;
    public AudioSource downtrain;
    [Header("����")]
    public AudioClip dragonSound;
    public AudioClip trainSound;

    private void Start()
    {
        dragon.clip     = dragonSound;
        uptrain.clip    = trainSound;
        downtrain.clip  = trainSound;
    }

}
