using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BTN_Controller : MonoBehaviour
{
    public string escena;

   //Para Audio:
    public AudioClip Click;
    AudioSource SoundPlayer;


    // Start is called before the first frame update
    void Start()
    {
      SoundPlayer = GetComponent<AudioSource>();      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CargarNivel()
     {
        if(escena == "Salir"){
           SoundPlayer.PlayOneShot(Click);
           Application.Quit();
        }
        else
        {
           SoundPlayer.PlayOneShot(Click);
           SceneManager.LoadScene(escena);
        }
     }
}
