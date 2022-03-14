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
    public int Score;
    public Text points;
    public int nivel;
    public Image reloj;
    //public GameObject Residuos_Generator;
    public GameObject GameManager;


    //Para Audio:
    public AudioClip Lvl_pass;
    AudioSource SoundPlayer;


    void Awake()
    {

        SoundPlayer = GetComponent<AudioSource>(); 
        if (nivel == 2)
        {
        SoundPlayer.PlayOneShot(Lvl_pass);
        }
        
    }


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

        // if (Residuos_Generator.GetComponent<Residuos_Generator>().items_pasando > 3 && Residuos_Generator.GetComponent<Residuos_Generator>().items_pasando < 6)
        // {  

        // } 
        // else if (Residuos_Generator.GetComponent<Residuos_Generator>().items_pasando > 6)
        // {

        // }


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
        yield return new WaitForSeconds(20f);
        SceneManager.LoadScene("Nivel_2");
        }

        if (scene_name == "Nivel_2")
        {
        yield return new WaitForSeconds(40f);
        SceneManager.LoadScene("Scene_Victoria");
        }
        
     }



     private void Derrota()
     { 
        SceneManager.LoadScene("Scene_Derrota");
     }

        private void Victoria()
     { 
        SceneManager.LoadScene("Scene_Victoria");
     }



     public void AddScore(int puntaje)
     {
         //reloj.fillAmount = 1;
         GameManager.GetComponent<GameManager>().Score = GameManager.GetComponent<GameManager>().Score + puntaje;
         if (GameManager.GetComponent<GameManager>().Score <= 0)
         {
            GameManager.GetComponent<GameManager>().Score = 0;
            points.text = "000000";
         }
         else
         {
            points.text = GameManager.GetComponent<GameManager>().Score.ToString();
         } 
        
     }





}
