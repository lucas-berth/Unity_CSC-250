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

    private void onTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            this.thisRoom.setPlayer(coreScript.getPlayer()); //lets the new room know about the player
            print("Player now in room: " + this.thisRoom);
        }
        else if(other.gameObject.tag.Equals("Enemy"))
        {
            print("Enemy entered room " + this.gameObject.ToString());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
