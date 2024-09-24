using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;

    public float Speed = 5.0f;
    float accelrationTime = 5f;
    float time = 0f;

    void Update()
    {
        Vector3 offset = Vector3.zero;

        

        
         

        if (Input.GetKey(KeyCode.LeftArrow))
            offset += Vector3.left * Speed;
        if (Input.GetKey(KeyCode.RightArrow))
            offset += Vector3.right * Speed;
        if (Input.GetKey(KeyCode.UpArrow))
            offset += Vector3.up * Speed;
        if (Input.GetKey(KeyCode.DownArrow))
            offset += Vector3.down * Speed;
        

        PlayerMovevement(offset);

    }

    private void PlayerMovevement(Vector3 offset)
    {
        for (time = 0f; time < accelrationTime * Time.deltaTime; time += Speed)
        {
            for (float MaxSpeed = 20.0f; Speed < MaxSpeed; Speed++)
            {
                transform.position += offset * Time.deltaTime;
            }
        }
        
    }

}
