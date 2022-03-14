using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public int Score = 0;
    public int lifeScore;
    public Text points;


    public bool playerDeadGameRestart;


    private void Awake()
    {
    
        MakeSingleton();
    }


    private void MakeSingleton ()

    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AddScore(int puntaje)
     {
         //reloj.fillAmount = 1;
         Score = Score +puntaje;
         //points.text = Score.ToString();
         
         /* if (Score < 1)
         {
            Score = 0;
            //points.text = "000000";
         }
         else
         {
            points.text = Score.ToString();
         }  */
         
        
     }


}
