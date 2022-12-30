using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] ParticleSystem finishParticle;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            finishParticle.Play();
            Invoke("ReloadScene", 1);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
