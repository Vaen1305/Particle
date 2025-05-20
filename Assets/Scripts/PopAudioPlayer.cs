using System.Runtime.CompilerServices;
using UnityEngine;

public class PopAudioPlayer : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
}
