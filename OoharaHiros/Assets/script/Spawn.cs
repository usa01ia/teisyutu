using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spawn : MonoBehaviour
{
    //プレハブ格納用
    public GameObject EnemyPrefab;
    public GameObject ToughEnemy;
    public GameObject FastEnemy;
    GameObject EnemySpawn;
    GameObject Camera;
    Vector3 Camerapos;


    int count;
    int Max;//敵の数の上限
    int RandomNum;//敵の出現する場所を決める
    int RandomEnemy;//出現する敵を決める
    float SpawnRightSide;
    float SpawnLeftSide;
    float SpawnUpSide;
    float SpawnDownSide;
    private void Start()
    {
    Camera = GameObject.Find("Main Camera");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Camerapos = Camera.transform.position;
        SpawnRightSide = Camerapos.x + 18.0f;
        SpawnLeftSide = Camerapos.x - 18.0f;
        SpawnUpSide = Camerapos.y + 8.0f;
        SpawnDownSide = Camerapos.y - 8.0f;
        count++;
        if (count > 30)
        {
            RandomNum = Random.Range(0, 4);
            RandomEnemy = Random.Range(0, 20);



            float xleft = Random.Range(SpawnLeftSide-5, SpawnLeftSide);
            float yleft = Random.Range(SpawnDownSide, SpawnUpSide);
            Vector3 posleft = new Vector3(xleft, yleft, 0);



            float xright = Random.Range(SpawnRightSide, SpawnRightSide+5);
            float yright = Random.Range(SpawnDownSide, SpawnUpSide);
            Vector3 posright = new Vector3(xright, yright, 0);



            float xtop = Random.Range(SpawnLeftSide, SpawnRightSide);
            float ytop = Random.Range(SpawnUpSide, SpawnUpSide+5);
            Vector3 postop = new Vector3(xtop, ytop, 0);



            float xunder = Random.Range(SpawnLeftSide,SpawnRightSide);
            float yunder = Random.Range(SpawnDownSide-5, SpawnDownSide);
            Vector3 posunder = new Vector3(xunder, yunder, 0);



            if (RandomEnemy < 14)
            {
                EnemySpawn = EnemyPrefab;
            }
            else if (RandomEnemy > 14 && RandomEnemy < 18)
            {
                EnemySpawn = FastEnemy;
            }
            else
            {
                EnemySpawn = ToughEnemy;
            }



            //プレハブを指定位置に生成
            switch (RandomNum)
            {
                case 0:
                    Instantiate(EnemySpawn, posleft, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(EnemySpawn, posright, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(EnemySpawn, postop, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(EnemySpawn, posunder, Quaternion.identity);
                    break;
            }
            count = 0;
        }
    }
}