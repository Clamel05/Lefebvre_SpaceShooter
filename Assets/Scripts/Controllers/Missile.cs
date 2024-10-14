using Codice.Client.BaseCommands.CheckIn.Progress;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Missile : MonoBehaviour
{

    public Transform Player;
    public float speed = 2f;

    public Vector3 directionToTarget;
    

    // Start is called before the first frame update
    void Start()
    {
        FindPlayerPosition();
        
    }


    public void FindPlayerPosition()
    {
        directionToTarget = (Player.position - transform.position).normalized;

        //Vector3 rotation = new Vector3(0, 0, 180);
        //transform.rotation = (0,0,rotation * Quaternion.identity);

    }

    public void Deflect()
    {
        directionToTarget = directionToTarget * (-1);
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FindPlayerPosition();
        }

        MissileSeeker();
        
    }

    void MissileSeeker()
    {
        transform.position += Time.deltaTime * speed * directionToTarget;
        Debug.DrawLine(transform.position, transform.position + directionToTarget, Color.red);
        
        
    }
}
