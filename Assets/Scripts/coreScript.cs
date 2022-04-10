using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coreScript : MonoBehaviour
{
    public Transform EnemyPrefab;
    public Transform spawnPoint;
    public int xPos;
    public int zPos;
    public int enemyCount;

    public static List<GameObject> theRooms = new List <GameObject>();
    
    //trying to make an array of the spawnpoints
    //spawnPoint = Transform.CompareTo("Enemy");

    public static void addRoomGO(GameObject go)
    {
        coreScript.theRooms.Add(go);
        print("Added Room");
    }
    public static void display()
    {
        print("Woot");
    }


    // Start is called before the first frame update
    void Start()
    {
        //trying to make an array of the spawnpoints
        //spawnPoint = Transform.CompareTo("Enemy");


        for(int i = 0; i < 10; i++)
        {
            print(Random.Range(1, 10));
        }
        /*
        for(int i = 0; i < 20; i++)
        {
            //spawnEnemys();
            Instantiate(EnemyPrefab, spawnPoint.position, Quaternion.identity);
        }
        */
        
        spawnEnemys();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnEnemys()
    {
       // int index = Random.Range(0, spawnPoint.Length);
        //var spawnpoints = spawnPoint[index];

        while (enemyCount < 20)
        {
            xPos = Random.Range(-30, 30);
            zPos = Random.Range(-30, 30);
            Instantiate(EnemyPrefab, new Vector3(xPos, 1, zPos), Quaternion.identity);
            enemyCount += 1;
        }
    }
}
