using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Collections.AllocatorManager;
using UnityEngine.Events;

public class sfxManager : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip[] SFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayClicked()
    {
        source.PlayOneShot(SFX[0]);

    }
    public void PlayDestroyed()
    {
        source.PlayOneShot(SFX[1]);
    }
}
