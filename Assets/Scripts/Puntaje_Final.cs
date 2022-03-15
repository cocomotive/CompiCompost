using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puntaje_Final : MonoBehaviour
{
    public Text puntaje;

    // Start is called before the first frame update
    void Start()
    {
        puntaje.text = GameManager.instance.Score.ToString();
        GameManager.instance.Score = 0;
        


        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
