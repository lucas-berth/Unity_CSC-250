using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    private Player thePlayer;
    private Rigidbody rb;
    public float speed = 20f;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = new Player("Mike");
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    public void DoSomething()
    {
        print("Player: Do something called");
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("enemy"))
        {
            count++;
            if(count == 3)
            {
                this.thePlayer.addKill();
                print("Kill Count: " + this.thePlayer.getKillCount());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //this is the game object that the script is attached to
       if (Input.GetKeyDown("up"))
       {
           print("up key was pressed");
           rb.velocity = Vector3.forward * speed;
       }
       else if (Input.GetKeyDown("down"))
       {
           print("down key was pressed");
           rb.velocity = Vector3.back * speed;
       }
       else if (Input.GetKeyDown("left"))
       {
           print("left key was pressed");
           rb.velocity = Vector3.left * speed;
       }
       else if (Input.GetKeyDown("right"))
       {
           print("right key was pressed");
           rb.velocity = Vector3.right * speed;
       }
       else if (Input.GetKeyDown("space"))
       {
           rb.velocity = Vector3.up * speed;
       }
        
    }
}
