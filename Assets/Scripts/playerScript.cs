using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    private Player thePlayer;

        // Start is called before the first frame update
        Vector3 goUp, goDown, goLeft, goRight, goJump;
        public float speed = 2.0f;
        private Rigidbody rb;
        private int count;

    void Start()
    {
        thePlayer = new Player("Lucas");
            //goUp = new Vector3(0.0f, 1.0f, 0.0f);
            //speed = 2.0f;
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    public void DoSomething()
    {
        print("Do something called");
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Enemy"))
        {
            count++
            if(count == 3)
            {
                this.thePlayer.addKill();
                print("Kill count: " + this.thePlayer.getkillCount());
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
