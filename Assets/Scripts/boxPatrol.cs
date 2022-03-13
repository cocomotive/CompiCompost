using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxPatrol : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    [SerializeField] private float minDistance;
    [SerializeField] private Transform[] movePoint;
    private int nextStep = 0;

    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
   transform.position = Vector2.MoveTowards(transform.position, movePoint[nextStep].position, moveSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position,movePoint[nextStep].position) < minDistance)
        {
            nextStep ++;
            if (nextStep>=movePoint.Length)
            {
                nextStep = 0;
            }
        }


    }
}
