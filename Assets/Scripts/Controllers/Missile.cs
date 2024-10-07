using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Missile : MonoBehaviour
{

    public Transform Player;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 speed = new Vector3(10, 10, 0);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = transform.position + speed * Time.deltaTime;
        }
        
    }
}
