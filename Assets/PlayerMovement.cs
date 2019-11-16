using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float rot_speed = 20f;
    private Rigidbody2D componentRigidbody;


    private void Awake()
    {
        componentRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Black math magic
        //вращение за мышью 
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        direction.Normalize();
        float zAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
        Quaternion desiredRotation = Quaternion.Euler(0, 0, zAngle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, rot_speed * Time.deltaTime);

        Vector3 orientation = new Vector3(Mathf.Cos(transform.rotation.z), Mathf.Sin(transform.rotation.z));
        if (Input.GetKey(KeyCode.Space))
            componentRigidbody.AddForce(orientation * speed);

    }


}
