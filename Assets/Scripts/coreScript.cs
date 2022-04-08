using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coreScript : MonoBehaviour
{
    public Transform EnemyPrefab;
    public Transform spawnPoint;

    public static List<GameObject> theRooms = new List <GameObject>();

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
        for(int i = 0; i < 10; i++)
        {
            print(Random.Range(1, 10));
        }
        
        Instantiate(EnemyPrefab, spawnPoint.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
