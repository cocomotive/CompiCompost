using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BTN_Controller : MonoBehaviour
{
    public string escena;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CargarNivel()
     {
        if(escena == "Salir"){
           Application.Quit();
        }
        else
        {
           SceneManager.LoadScene(escena);
        }
     }
}
