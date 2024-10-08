using Codice.Client.BaseCommands.CheckIn.Progress;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Missile : MonoBehaviour
{

    public Transform Player;
    public float speed = 2f;

    private Vector3 diretionToTarget;

    // Start is called before the first frame update
    void Start()
    {
        FindPlayerPosition();
    }

    private void FindPlayerPosition()
    {
        diretionToTarget = (Player.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FindPlayerPosition();
        }

        MissileSeeker();
    }


    void MissileSeeker()
    {
        Debug.DrawLine(transform.position, transform.position + diretionToTarget, Color.red);
        transform.position += Time.deltaTime * speed * diretionToTarget;

        //if (transform.position != Player.position)
        //{
        //    Vector3 Playerposition = Player.position;
        //    transform.position = transform.position + Playerposition * speed * Time.deltaTime;
        //}
        //else
        //{
        //    speed = 0;
        //    Debug.Log("Hit");
        //}
    }
}

