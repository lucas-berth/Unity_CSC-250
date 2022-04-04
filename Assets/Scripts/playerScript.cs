using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Player thePlayer;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = new Player("Lucas");
    }

    // Update is called once per frame
    void Update()
    {
        print(thePlayer.getName());
    }
}
