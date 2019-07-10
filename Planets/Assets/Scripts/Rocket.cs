using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField]
    private float maxSpeedToLand;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (IsPlanet(collision.gameObject) && IsBigVelocity(collision.gameObject))
        {
            Debug.Log("TOO FAST!1!");
        }
    }

    private bool IsPlanet(GameObject obj)
    {
        return obj.tag == "Planet";
    }

    private bool IsBigVelocity(GameObject obj)
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        Rigidbody2D objRb2d = obj.GetComponent<Rigidbody2D>();
        Vector2 velocityDiff = objRb2d.velocity - rb2d.velocity;

        Debug.Log("Speed = " + velocityDiff.magnitude);
        return (velocityDiff.magnitude > maxSpeedToLand);
    }
}
