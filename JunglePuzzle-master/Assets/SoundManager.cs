using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip JumpSound,EnemyHitSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        JumpSound = Resources.Load<AudioClip>("Jump");
        EnemyHitSound = Resources.Load<AudioClip>("EnemyHit");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Jump":
                audioSrc.PlayOneShot(JumpSound);
                break;
            case "EnemyHit":
                audioSrc.PlayOneShot(EnemyHitSound);
                break;

        }
    }
}
