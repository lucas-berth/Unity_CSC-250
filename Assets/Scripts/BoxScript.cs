using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BoxScript : MonoBehaviour
{
    private int count;
    private Rigidbody rb;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        count = 0;
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            count++;
            if(count == 3)
            {
                this.gameObject.SendMessage("DoSomething");
                Destroy(this.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //try to make the enemy move by itself
        //rb.velocity = Vector3.forward * speed;
        randomPosition();
    }

    void randomPosition()
    {
        int ran = Random.Range(1, 4);
        if(ran == 1)
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if(ran == 2)
        {
            rb.velocity = Vector3.back * speed;
        }
        else if(ran == 3)
        {
            rb.velocity = Vector3.left * speed;
        }
        else if(ran == 4)
        {
            rb.velocity = Vector3.right * speed;
        }
    }
}
