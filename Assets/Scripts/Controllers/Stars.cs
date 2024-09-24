using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public List<Transform> starTransforms;
    public float drawingTime;

    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    public GameObject Star4;
    public GameObject Star5;
    public GameObject Star6;
    public GameObject Star7;

    

    // Update is called once per frame
    void Update()
    {
        DrawConstelation();
    }

    public void DrawConstelation()
    {
        Vector3 Star1Pos = new Vector3(Star1.transform.position.x, Star1.transform.position.y, 0);
        Vector3 Star2Pos = new Vector3(Star2.transform.position.x, Star2.transform.position.y, 0);


        Debug.DrawLine(Star1Pos, Star2Pos, Color.red);
        Debug.DrawLine(Star2.transform.position, Star3.transform.position, Color.red);
        Debug.DrawLine(Star3.transform.position, Star4.transform.position, Color.red);
        Debug.DrawLine(Star4.transform.position, Star5.transform.position, Color.red);
        Debug.DrawLine(Star5.transform.position, Star6.transform.position, Color.red);
        Debug.DrawLine(Star6.transform.position, Star7.transform.position, Color.red);


    }

}
