using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public Transform planetTransform;

    public GameObject PlanetPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //OrbitalMotion();
    }








    public void OrbitalMotion(float radius = 3, float speed = 5, Transform target = null)
    {

        float position = 0;
        float radians = (Mathf.Deg2Rad * ((position + speed) * Time.deltaTime));
        float xPos = Mathf.Cos(radians);
        float yPos = Mathf.Sin(radians);

        Vector3 Orbit = transform.position + (new Vector3(xPos, yPos, 0f) * radius);


        Instantiate(planetTransform, Orbit, Quaternion.identity);
    }









}
