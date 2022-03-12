using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Residuos_Generator : MonoBehaviour
{
    public float startAt;
    public float repeatIn;
    public GameObject Item_prefab1;
    public GameObject Item_prefab2;
    //public GameObject Item_prefab3;
    private int nro_item;
    private int posX;
   
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3 (posX, 150, 0);
        InvokeRepeating("SpawnItem", startAt, repeatIn);   
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnItem()
    {    
        nro_item = Random.Range(1,3);
        if (nro_item == 1)
        {
            transform.position = new Vector3 (-1050, 350, 0);    
        GameObject Item = Instantiate(Item_prefab1, transform.position, transform.rotation) as GameObject;
        Item.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
        }
        else
        //if (nro_item == 2)
        {
            transform.position = new Vector3 (-1050, 350, 0);    
        GameObject Item = Instantiate(Item_prefab2, transform.position, transform.rotation) as GameObject;
        Item.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
        }
        // else
        // {
        //     transform.position = new Vector3 (-650, 150, 0);    
        // GameObject Item = Instantiate(Item_prefab3, transform.position, transform.rotation) as GameObject;
        // Item.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);

        // }
        

    }

}
