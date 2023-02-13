using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Header("사운드 끌어가기")]
    public AudioSource attackSound;
    public AudioSource takeHitSound;
    public AudioSource walkSound;
    [Header("사운드 주체")]
    public AudioSource dragon;
    public AudioSource uptrain;
    public AudioSource downtrain;
    [Header("사운드")]
    public AudioClip dragonSound;
    public AudioClip trainSound;

    private void Start()
    {
        dragon.clip = dragonSound;
        uptrain.clip = trainSound;
        downtrain.clip = trainSound;
    }

   



}
