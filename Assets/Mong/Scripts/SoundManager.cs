using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Header("���� ��ü")]
    public AudioSource audioSource;
   public AudioSource dragon;
   public AudioSource uptrain;
   public AudioSource downtrain;
    public AudioSource lava;
    [Header("����")]
    public AudioClip attackSound;
   public AudioClip takeHitSound;
    public AudioClip walkSound;
    public AudioClip dragonSound;
    public AudioClip trainSound;
    public AudioClip lavaSound;

    private void Start()
    {
        dragon.clip = dragonSound;
        uptrain.clip = trainSound;
        downtrain.clip = trainSound;
        lava.clip = lavaSound;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && audioSource.clip != takeHitSound)
        {
            audioSource.Stop();
            audioSource.clip = takeHitSound;
            audioSource.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Space) && audioSource.clip != attackSound)
        {
            audioSource.Stop();
            audioSource.clip = attackSound;
            audioSource.Play();
        }
    }




}
