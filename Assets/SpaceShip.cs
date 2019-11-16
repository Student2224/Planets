using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : SkyBody
{
    float engine_power;
    float rotation_speed;

    void Rotate(Vector3 target)
    {
        Vector3 direction = target - transform.position;
        direction.Normalize();
        float zAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
        Quaternion desiredRotation = Quaternion.Euler(0, 0, zAngle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, rotation_speed * Time.deltaTime);
    }

    void SetEngine(bool engineIsOn)
    { 
    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
