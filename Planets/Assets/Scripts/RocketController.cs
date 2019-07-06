using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    private Gravity gravity;
    void Awake()
    {
        gravity = gameObject.GetComponent<Gravity>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = (Camera.main.ScreenToWorldPoint(Input.mousePosition));
        var distance = Vector3.Distance(transform.position, mousePos);
        float speedx = -(transform.position.x - mousePos.x);
        float speedY = -(transform.position.y - mousePos.y);
        transform.up = new Vector2(speedx, speedY);
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
