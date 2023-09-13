using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;


public class TeacherMove : MonoBehaviour
{
    //GameObjectで追尾するターゲットの読み込み
    GameObject target;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("player");

    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position, target.transform.position, 2 * Time.deltaTime);

       

    }
}
