using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;

    public GameObject PowerUpPrefab;

    public float Speed = 0.0f;
    //float accelrationTime = 5f;
    //float time = 0f;
    public float MaxSpeed = 20.0f;

    void Update()
    {
        Vector3 offset = Vector3.zero;

        /*for(time = 0f; time < accelrationTime * Time.deltaTime; time += Speed)
        {
            for (MaxSpeed = 20.0f; Speed < MaxSpeed; Speed++)
            {

            }
        }*/



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            offset += Vector3.left * Speed;
            for (MaxSpeed = 20.0f; Speed < MaxSpeed; Speed++) ;
        }
        else
            if (Speed > 0)
        {
            Speed--;
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            offset += Vector3.right * Speed;
            for (MaxSpeed = 20.0f; Speed < MaxSpeed; Speed++) ;
        }
        else
            if (Speed > 0)
        {
            Speed--;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            offset += Vector3.up * Speed;
            for (MaxSpeed = 20.0f; Speed < MaxSpeed; Speed++) ;
        }
        else
            if(Speed > 0)
        {
            Speed--;
        }
            

        if (Input.GetKey(KeyCode.DownArrow))
        {
            offset += Vector3.down * Speed;
            for (MaxSpeed = 20.0f; Speed < MaxSpeed; Speed++) ;
        }
        else
            if (Speed > 0)
        {
            Speed--;
        }


        PlayerMovevement(offset);

        //Week4 Task1
        EnemyRadar();

        //Week4 Task2
        //SpawnPowerups();

    }

  
    private void EnemyRadar(float radius = 3, int CirclePoints = 6)
    {
        for(int i = 0; i < CirclePoints; i++)
        {
            float radians = (Mathf.Deg2Rad * (360 / CirclePoints) * i+1);
            float xPos = Mathf.Cos(radians);
            float yPos = Mathf.Sin(radians);

            Vector3 endPoint = transform.position + (new Vector3(xPos, yPos, 0f) * radius);

            float radians2 = (Mathf.Deg2Rad * (360 / CirclePoints)) * i;
            float xPos2 = Mathf.Cos(radians2);
            float yPos2 = Mathf.Sin(radians2);

            Vector3 startPoint = transform.position + (new Vector3(xPos2, yPos2, 0f) * radius);

            Debug.DrawLine(startPoint, endPoint, Color.green);
        }

    }

    public void SpawnPowerups(float radius = 3, int numberOfPowerups = 4)
    {
        for(int i = 0; i < numberOfPowerups; i++)
        {
            float radians = (Mathf.Deg2Rad * (360 / numberOfPowerups)) * i;
            float xPos = Mathf.Cos(radians);
            float yPos = Mathf.Sin(radians);

            Vector3 Position = transform.position + (new Vector3(xPos, yPos, 0f) * radius);

            Instantiate(PowerUpPrefab, Position, Quaternion.identity);
        }

    }






    private void PlayerMovevement(Vector3 offset)
    {
        transform.position += offset * Time.deltaTime;
    }

}
