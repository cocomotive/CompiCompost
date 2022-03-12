using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Item_generator : MonoBehaviour
{
    public float startAt;
    public float repeatIn;
    public GameObject Item_prefab;
    private int posX;
   
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3 (posX, 50, 0);
        InvokeRepeating("SpawnItem", startAt, repeatIn);   
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnItem()
    {    
        posX = Random.Range(-300,350);
        transform.position = new Vector3 (posX, 50, 0);    
        GameObject Item = Instantiate(Item_prefab, transform.position, transform.rotation) as GameObject;
        Item.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);

    }

}
