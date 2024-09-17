using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;


    void Update()
    {
        Vector3 offset = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
            offset += Vector3.left * 0.01f;
        if (Input.GetKey(KeyCode.RightArrow))
            offset += Vector3.right * 0.01f;
        if (Input.GetKey(KeyCode.UpArrow))
            offset += Vector3.up * 0.01f;
        if (Input.GetKey(KeyCode.DownArrow))
            offset += Vector3.down * 0.01f;

        PlayerMovevement(offset);

    }

    private void PlayerMovevement(Vector3 offset)
    {
        transform.position += offset;
    }

}
