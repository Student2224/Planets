using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb2d;
    [SerializeField]
    private float thrustValue;

    void Update()
    {
        Vector3 mousePos = (Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Vector2 direction = mousePos - transform.position;
        transform.up = direction;

        if (Input.GetMouseButton(0))
        {
            rb2d.AddForce(transform.up * thrustValue);
        }
    }
}
