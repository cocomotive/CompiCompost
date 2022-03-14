using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float timer;
    public float currentTimer;
    public Image timeUI;

    // Start is called before the first frame update
    void Start()
    {
        currentTimer = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTimer <= 0)
        {
            SceneManager.LoadScene("Scene_Derrota");
            Debug.Log("Perdiste, te quedaste sin tiempo gil");
            currentTimer = 0;
            
        }
        else
        {
            currentTimer -= Time.deltaTime;
            timeUI.fillAmount = currentTimer / timer;
            if (currentTimer == 0)
            {
                currentTimer = 0;
            }
        }
    }
}
