using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Controller : MonoBehaviour
{
    public bool Pause;
    public GameObject Instrucciones;
    public string scene_name;
    public int Score = 0;
    public Text points;
    // Start is called before the first frame update
    void Start()
    {
        
        //scene_name = SceneManager.GetActiveScene().ToString();
        StartCoroutine(Next_Level());
        Pause = true; 
    }
    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
    {
    Pause = !Pause;
    }

    if(Pause)
    {
    Instrucciones.SetActive(true);
	Time.timeScale = 0;
    }
    else
    {
    Instrucciones.SetActive(false);
	Time.timeScale = 1;
    }
       
    }



    private IEnumerator Next_Level()
     { 
        if (scene_name == "Nivel_1")
        {
        yield return new WaitForSeconds(60f);
        SceneManager.LoadScene("Nivel_2");
        }
        
     }

     public void AddScore()
     {
        Score = Score +1000 ;
        points.text = "Score: "+Score.ToString();

     }



}
