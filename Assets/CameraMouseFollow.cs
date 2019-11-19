using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Menu
public class CameraMouseFollow : MonoBehaviour
{
    Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        transform.position = (mousePos - startPosition - new Vector3(Screen.width,Screen.height)*0.5f)*0.005f;
        this.transform.position   = new Vector3(transform.position.x,transform.position.y,startPosition.z);
    }
}
