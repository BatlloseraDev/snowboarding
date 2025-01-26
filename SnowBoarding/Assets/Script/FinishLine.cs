using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay =1f; 
    [SerializeField] ParticleSystem finishEffect; 
    bool isFinish = false; 

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player") && !isFinish)
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();   
            Invoke("ReloadScene",loadDelay);
            isFinish= true;            
        }
            
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
