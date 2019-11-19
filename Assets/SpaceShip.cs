using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : SkyBody
{
    public float helth = 100;
    public float fuel = 100;
    public float delta_fuel = 0.001f;//part of fuel per single engine impulse

    public float 
        engine_power = 2, // general engine power
        engine_power_forward = 1,// main engine
        engine_power_back = 1,//back engine power
        engine_power_sideways = 1, // power of side engins
        engine_stop_power=0.99f; //<=1

    public bool
        //stop engine 
        stop =false,
        //engins is on
        forward = false, 
        back = false, 
        right = false,
        left = false,
        //is rotate
        rotation_left = false,  // FIXME
        rotation_right = false; //
        
    public void Fire()
    {
        //call me AI! or Player!!

        //here creating projectile
    }
    public float rotation_speed = 70;//how many rad/sec FIXME

    public void Rotate(Vector3 target)
    {
        Vector3 direction = target - transform.position;
        direction.Normalize();
        float zAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
        Quaternion desiredRotation = Quaternion.Euler(0, 0, zAngle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, rotation_speed * Time.deltaTime);
    }
    void Rotate(float angle_speed)
    {
        if (angle_speed > rotation_speed)
            angle_speed = rotation_speed;

        //TODO
    }

    public void Rotate()
    {
        Vector3 direction = transform.right;
        direction.Normalize();
        float zAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
        Quaternion desiredRotation = Quaternion.Euler(0, 0, zAngle);

        if (rotation_left)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, -rotation_speed * Time.deltaTime);
        }
        if (rotation_right)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, rotation_speed * Time.deltaTime);
        }
        
    }

    public void EnginController()
    {
        if (fuel <= 0)
            return;
        if (helth < 0)
            throw new System.Exception("destroy engines if healf<=0");

    
        if (forward)
        {
            componentRigidbody.AddForce(transform.up * engine_power_forward * engine_power);
            fuel -= delta_fuel;
        }
        if (back)
        {
            componentRigidbody.AddForce(-transform.up * engine_power_back * engine_power);
            fuel -= delta_fuel;
        }
        if (left)
        {
            componentRigidbody.AddForce(-transform.right * engine_power_sideways * engine_power);
            fuel -= delta_fuel;
        }
        if (right)
        {
            componentRigidbody.AddForce(transform.right * engine_power_sideways * engine_power);
            fuel -= delta_fuel;
        }
        
        if (stop)
        {
            componentRigidbody.velocity *= engine_stop_power;
            fuel -= delta_fuel;
        }
    }

    private void Awake()
    {
        componentRigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        EnginController();
        Rotate();
    }
}
