using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        coreScript.addRoomGO(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Room Entered: " + this.gameObject.ToString());
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag.Equals("Enemy"))
        {
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag.Equals("Player"))
        {
            Destroy(other.gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
