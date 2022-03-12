using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class truckMov : MonoBehaviour
{
    public float moveSpeed;
    public GameObject truck;
    public new Vector3 respawn;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 8)
        {
            truck.transform.position = respawn;
            Debug.Log("entro");
        }
    }
}
