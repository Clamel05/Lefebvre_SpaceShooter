using Codice.Client.BaseCommands.CheckIn.Progress;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Missile : MonoBehaviour
{

    public Transform Player;
    public float speed = 2f;
    public float rotateSpeed = 1.0f;

    public Vector3 directionToTarget;

    private Quaternion lookRotation;

    // Start is called before the first frame update
    void Start()
    {
        

        FindPlayerPosition();
        
    }


    public void FindPlayerPosition()
    {
        directionToTarget = (Player.position - transform.position).normalized;

        //My attempt at rotating the missile
        //transform.LookAt(Player);

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

        //My other attempt at rotating the missile
        //lookRotation = Quaternion.LookRotation(directionToTarget);
        //transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotateSpeed);

    }

    void MissileSeeker()
    {
        transform.position += Time.deltaTime * speed * directionToTarget;
        Debug.DrawLine(transform.position, transform.position + directionToTarget, Color.red);
    }
}
