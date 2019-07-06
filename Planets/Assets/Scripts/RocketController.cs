using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePos = (Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Vector2 direction = mousePos - transform.position;
        transform.up = direction;
    }
    void OnMouseDown()
    {
        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //var distance = Vector3.Distance(transform.position, mousePos);
        //float speedX = -(transform.position.x - mousePos.x) / distance;
        //float speedY = -(transform.position.y - mousePos.y) / distance;
        //gravity.AddSpeed(new Vector2(speedX, speedY));
        
    }
}
