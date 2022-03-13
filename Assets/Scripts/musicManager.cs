using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class musicManager : MonoBehaviour
{
    public static musicManager daMusicManager;

    // Start is called before the first frame update
    void Start()
    {
        if (daMusicManager == null)
        {
            daMusicManager = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 2)

        {
            Destroy(gameObject);
        }
    }
}
