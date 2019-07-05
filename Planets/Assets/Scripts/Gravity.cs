using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public static List<Gravity> ListOfObjects = new List<Gravity>();
    [SerializeField]
    private float mass;
    [SerializeField]
    private Vector2 speed;

    public void AddSpeed(Vector2 speed)
    {
        this.speed += speed;
    }

    void Awake()
    {
        ListOfObjects.Add(this);
    }

    void Update()
    {
        foreach (Gravity item in ListOfObjects)
        {
            if (item != this)
            {
                CalculateSpeed(item);
            }
        }
        CalculatePosition();
    }

    private void CalculateSpeed(Gravity other)
    {

        float distance = Vector3.Distance(transform.position, other.transform.position);
        float acceleration = -other.mass / (distance * distance);
        speed.x += acceleration * (transform.position.x - other.transform.position.x) / distance * Time.deltaTime;
        speed.y += acceleration * (transform.position.y - other.transform.position.y) / distance * Time.deltaTime;
    }

    private void CalculatePosition()
    {
        transform.position += new Vector3(speed.x, speed.y);
    }
}
