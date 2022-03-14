using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Feedback_Malo_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DestroyItem", 0.5f, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyItem()
    {      
         Destroy(gameObject);
    }

}
