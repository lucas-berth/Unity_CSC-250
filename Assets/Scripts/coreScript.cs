using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coreScript : MonoBehaviour
{
    public Transform EnemyPrefab;
    public Transform[] spawnPoint;

    public static List<GameObject> theRooms = new List <GameObject>();
    
    //trying to make an array of the spawnpoints
    spawnPoint = Transform.CompareTo("Enemy");

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
        spawnPoint = Transform.CompareTo("Enemy");


        for(int i = 0; i < 10; i++)
        {
            print(Random.Range(1, 10));
        }
        for(int i = 0; i < 20; i++)
        {
            spawnEnemys();
        }
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnEnemys()
    {
        int index = Random.Range(0, spawnPoint.Length);
        //var spawnpoints = spawnPoint[index];

        Instantiate(EnemyPrefab, spawnPoint[index].position, Quaternion.identity);
    }
}
