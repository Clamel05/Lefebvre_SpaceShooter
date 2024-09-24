using UnityEngine;
using System.Collections;
using Codice.CM.Common;
using Codice.Client.BaseCommands.CheckIn.Progress;

public class Enemy : MonoBehaviour
{
    public float Speed = 10.0f;
    public float Dash = 20.0f;
    public float Timer = 3.0f * Time.deltaTime;

    void Update()
    {
        Vector3 offset = Vector3.zero;


        if (Input.GetKey(KeyCode.A))
        {
            offset += Vector3.left * Speed;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                float SpeedReset = Speed;
                Speed = Speed + Dash;

                for(Timer = 3.0f; Timer > 0; Timer-=Time.deltaTime)
                {
                    Speed = SpeedReset;
                }

            }


        }

        if (Input.GetKey(KeyCode.D))
        {
            offset += Vector3.right * Speed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            offset += Vector3.up * Speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            offset += Vector3.down * Speed;
        }



        PlayerMovevement(offset);

    }

    private void PlayerMovevement(Vector3 offset)
    {
        transform.position += offset * Time.deltaTime;
    }

}
