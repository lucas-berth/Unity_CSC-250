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

    public static List<GameObject> theRoomGos = new List <GameObject>();
    public static List<Room> theRooms = new List<Room>();

    private static Player currentPlayer = null;

    public static void setPlayer(Player p)
    {
        coreScript.currentPlayer = p;
    }

    public static Player getPlayer()
    {
        return coreScript.currentPlayer;
    }

    public static void addRoom(Room theRoom)
    {
        coreScript.theRooms.Add(theRoom);
    }
    
    //trying to make an array of the spawnpoints
    //spawnPoint = Transform.CompareTo("Enemy");

    public static void addRoomGO(GameObject go)
    {
        coreScript.theRoomGos.Add(go);
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

        /*
        for(int i = 0; i < 20; i++)
        {
            Transform t = Instantiate(EnemyPrefab, spawnPoint.position, Quaternion.identity);
            Rigidbody rb = t.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(Random.Range(10, 30), 0, Random.Range(10, 30));

        }
        */
        
        //spawnEnemys();
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
            //add enemy to total count
            enemyCount += 1;
            //make the loop wait 1 second before spawning new enemy
            //yield return new WaitForSeconds(1);
           // BoxScript.randomPosition();
        }
    }
}
