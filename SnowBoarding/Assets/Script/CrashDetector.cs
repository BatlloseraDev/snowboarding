using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay =0.5f; 
    [SerializeField] ParticleSystem hitEffect;
    [SerializeField] AudioClip crashSFX;
    bool crashed = false; 
   void OnTriggerEnter2D(Collider2D other) 
    {
       if(other.CompareTag("Ground") && !crashed)
        { 
            FindObjectOfType<PlayerController>().DisableControls(); 
            hitEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX); 
            Invoke("ReloadScene",loadDelay); 
            crashed= true; 
        }
    }


    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
