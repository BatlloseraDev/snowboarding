using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] ParticleSystem trailEffect; 
    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.transform.tag== "Ground") trailEffect.Play();
    }
    void OnCollisionExit2D(Collision2D other) 
    {
        if(other.transform.tag== "Ground") trailEffect.Stop();
    }
}
