using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomTriggerScript : MonoBehaviour
{
    private Room thisRoom;
    
    // Start is called before the first frame update
    void Start()
    {
        this.thisRoom = new Room();
        coreScript.addRoom(this.thisRoom);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            this.thisRoom.setPlayer(coreScript.getPlayer()); //lets the new room know about the player
            print("Player now in room: " + this.thisRoom);
        }
        else if(other.gameObject.tag.Equals("Enemy"))
        {
            this.thisRoom.setEnemy(coreScript.getEnemy());
            print("Enemy now in room " + this.thisRoom);
        }
        
    }


    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag.Equals("Enemy"))
        {
            print("Room destroyed");
           // Destroy(coreScript.getEnemy.getRoom());
        }
        else if(other.gameObject.tag.Equals("Player"))
        {
            //game does get into this statement but probably does not have the correct room
            print("Player Destroyed Room");
            //Destroy(coreScript.getRoom().gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
