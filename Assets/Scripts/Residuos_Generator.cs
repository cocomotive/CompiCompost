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
    public GameObject Item_prefab3;
    public GameObject Item_prefab4;
    public GameObject Item_prefab5;
    public GameObject Item_prefab6;
    public GameObject Item_prefab7;
    public GameObject Item_prefab8;
    public GameObject Item_prefab9;
    public GameObject Item_prefab10;
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
        nro_item = Random.Range(1,11);
        transform.position = new Vector3 (-1050, 350, 0);
        
        if (nro_item == 1)
        {
        GameObject Item = Instantiate(Item_prefab1, transform.position, transform.rotation) as GameObject;
        Item.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
        }
        else if (nro_item == 2)
        {   
        GameObject Item = Instantiate(Item_prefab2, transform.position, transform.rotation) as GameObject;
        Item.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
        }
        else if (nro_item == 3)
        {    
        GameObject Item = Instantiate(Item_prefab3, transform.position, transform.rotation) as GameObject;
        Item.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
        }
        else if (nro_item == 4)
        {  
        GameObject Item = Instantiate(Item_prefab4, transform.position, transform.rotation) as GameObject;
        Item.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
        }
        else if (nro_item == 5)
        {   
        GameObject Item = Instantiate(Item_prefab5, transform.position, transform.rotation) as GameObject;
        Item.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
        }
        else if (nro_item == 6)
        {    
        GameObject Item = Instantiate(Item_prefab6, transform.position, transform.rotation) as GameObject;
        Item.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
        }
        else if (nro_item == 7)
        {   
        GameObject Item = Instantiate(Item_prefab7, transform.position, transform.rotation) as GameObject;
        Item.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
        }
        else if (nro_item == 8)
        {   
        GameObject Item = Instantiate(Item_prefab8, transform.position, transform.rotation) as GameObject;
        Item.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
        }
        else if (nro_item == 9)
        {   
        GameObject Item = Instantiate(Item_prefab9, transform.position, transform.rotation) as GameObject;
        Item.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
        }
        else
        {    
        GameObject Item = Instantiate(Item_prefab10, transform.position, transform.rotation) as GameObject;
        Item.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
        }
        

    }

}
