using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;

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

    }

    private void PlayerMovevement(Vector3 offset)
    {
        transform.position += offset * Time.deltaTime;
    }

}
