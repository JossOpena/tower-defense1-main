using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("----------Audio Source---------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("----------Audio Clip---------")]
    public AudioClip background;
    public AudioClip buttonclick;
    public AudioClip arrowshot;
    public AudioClip mageshot;
    public AudioClip towerupgrade;
    public AudioClip towerplacement;
    public AudioClip towersell;

}
