using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemywrok : MonoBehaviour
{
    GameObject target1;
    GameObject target2;

    private void Start()
    {
        target1 = GameObject.Find("player");
        target2 = GameObject.Find("start");
    }

    void Update()
    { 
        for(bool i = 1; i <= 2;)
        {
        if(i = 1)
        {
        transform.position = Vector2.MoveTowards(transform.position, target1.transform.position, 2 * Time.deltaTime);
                i++;
        }
        else
        {
        transform.position = Vector2.MoveTowards(transform.position, target2.transform.position, 2 * Time.deltaTime);
                i--;
        }

        }
    }
}