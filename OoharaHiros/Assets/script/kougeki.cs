using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject target;

    private void Start()
    {
        target = GameObject.Find("enemy1prehub");
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, 2 * Time.deltaTime);
    }
}
