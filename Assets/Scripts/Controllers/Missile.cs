using Codice.Client.BaseCommands.CheckIn.Progress;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Missile : MonoBehaviour
{

    public Transform Player;
    Vector3 speed = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MissileSeeker();
        
    }


    void MissileSeeker()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (transform.position != Player.position)
            {
                Vector3 speed = Player.position;
                transform.position = transform.position + speed * Time.deltaTime;
            }
            else
            {
                speed = Vector3.zero;
                Debug.Log ("Hit");
            }
                
        }

        
            
        

    }
}

