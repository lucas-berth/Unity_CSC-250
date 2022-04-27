using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Room
{

   private Player thePlayer;
   private Enemy theEnemy;
   private GameObject currentRoomTrigger;

   public Room(GameObject currentRoomTrigger)
   {  
       this.currentRoomTrigger = currentRoomTrigger;
       this.thePlayer = null;
       this.theEnemy = null;
   }

   public void setPlayer(Player p)
   {
      this.thePlayer = p;
      //access the old room the player was in
      if(p.getRoom() != null)
      {
         Room playerCurrentRoom = p.getRoom();
         coreScript.destroyRoomGOGivenTrigger(playerCurrentRoom.getRoomTrigger());
      }
      this.thePlayer.setRoom(this); //let the player know they are in a new room 
      
   }

   public Player getPlayer()
   {
      return this.thePlayer;
   }

   public void setEnemy(Enemy e)
   {
      this.theEnemy = e;
      if(e.getRoom() != null)
      {
         Room enemyCurrentRoom = e.getRoom();
         coreScript.destroyRoomGOGivenTrigger(enemyCurrentRoom.getRoomTrigger());
      }
      this.theEnemy.setRoom(this);
      
   }

   public Enemy getEnemy()
   {
      return this.theEnemy;
   }

   //this is not needed because we inside the class, but does not hurt
   public GameObject getRoomTrigger()
   {
      return this.currentRoomTrigger;
   }

}
